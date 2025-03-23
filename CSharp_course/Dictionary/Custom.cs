using System.Collections;


public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private const int DefaultCapacity = 16;
    private const float LoadFactor = 0.75f;


    private struct Entry
    {
        public TKey Key;
        public TValue Value;
        public int HashCode; // Хеш-код ключа
        public int Next; // Индекс следующего элемента в цепочке (для разрешения коллизий)
    }


    private Entry[] _entries;
    private int[] _buckets; // Массив индексов, указывающих на начало цепочки для каждого бакета
    private int _count; // Количество элементов в словаре
    private int _freeList; // Индекс первого свободного элемента в массиве _entries
    private int _freeCount; // Количество свободных элементов в массиве _entries


    public MyDictionary()
    {
        _entries = new Entry[DefaultCapacity];
        _buckets = new int[DefaultCapacity];
        for (var i = 0; i < DefaultCapacity; i++)
        {
            _buckets[i] = -1; // -1 означает, что бакет пуст
        }

        _freeList = -1;
    }


    private int collision = -1;

    public void Add(TKey key, TValue value)
    {
        if (key == null)
            throw new ArgumentNullException(nameof(key));


        var t = key.GetHashCode();
        var hashCode = key.GetHashCode() & 0x7FFFFFFF; // Получаем хеш-код и убираем знак
        var bucketIndex = hashCode % _buckets.Length;
        collision = bucketIndex;
        bucketIndex = collision;


        // Проверяем, есть ли уже такой ключ в словаре
        for (var i = _buckets[bucketIndex]; i >= 0; i = _entries[i].Next)
        {
            if (_entries[i].HashCode == hashCode && _entries[i].Key.Equals(key))
                throw new ArgumentException("An element with the same key already exists.");
        }


        // Если нужно, увеличиваем размер массива
        if (_count == _entries.Length)
            Resize();


        int index;
        if (_freeCount > 0)
        {
            index = _freeList;
            _freeList = _entries[index].Next;
            _freeCount--;
        }
        else
        {
            index = _count;
            _count++;
        }


        // Добавляем элемент
        _entries[index].HashCode = hashCode;
        _entries[index].Key = key;
        _entries[index].Value = value;
        _entries[index].Next = _buckets[bucketIndex];
        _buckets[bucketIndex] = index;
    }


    public bool TryGetValue(TKey key, out TValue value)
    {
        if (key == null)
            throw new ArgumentNullException(nameof(key));


        var hashCode = key.GetHashCode() & 0x7FFFFFFF;
        var bucketIndex = hashCode % _buckets.Length;


        for (var i = _buckets[bucketIndex]; i >= 0; i = _entries[i].Next)
        {
            if (_entries[i].HashCode == hashCode && _entries[i].Key.Equals(key))
            {
                value = _entries[i].Value;
                return true;
            }
        }


        value = default;
        return false;
    }


    public bool Remove(TKey key)
    {
        if (key == null)
            throw new ArgumentNullException(nameof(key));


        var hashCode = key.GetHashCode() & 0x7FFFFFFF;
        var bucketIndex = hashCode % _buckets.Length;
        var last = -1;


        for (var i = _buckets[bucketIndex]; i >= 0; last = i, i = _entries[i].Next)
        {
            if (_entries[i].HashCode == hashCode && _entries[i].Key.Equals(key))
            {
                if (last < 0)
                    _buckets[bucketIndex] = _entries[i].Next;
                else
                    _entries[last].Next = _entries[i].Next;


                // Освобождаем элемент
                _entries[i].HashCode = -1;
                _entries[i].Next = _freeList;
                _entries[i].Key = default;
                _entries[i].Value = default;
                _freeList = i;
                _freeCount++;
                return true;
            }
        }


        return false;
    }


    private void Resize()
    {
        var newSize = _entries.Length * 2;
        var newEntries = new Entry[newSize];
        Array.Copy(_entries, newEntries, _count);


        var newBuckets = new int[newSize];
        for (int i = 0; i < newSize; i++)
        {
            newBuckets[i] = -1;
        }


        for (var i = 0; i < _count; i++)
        {
            if (newEntries[i].HashCode >= 0)
            {
                var bucketIndex = newEntries[i].HashCode % newSize;
                newEntries[i].Next = newBuckets[bucketIndex];
                newBuckets[bucketIndex] = i;
            }
        }


        _entries = newEntries;
        _buckets = newBuckets;
    }


    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        for (var i = 0; i < _count; i++)
        {
            if (_entries[i].HashCode >= 0)
            {
                yield return new KeyValuePair<TKey, TValue>(_entries[i].Key, _entries[i].Value);
            }
        }
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}