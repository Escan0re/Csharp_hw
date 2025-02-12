namespace MyCustomList;

public class MyList<T> where T : IComparable<T>
{
    private T[] _array;
    public int Capacity { get; set; }
    public int Count { get; set; }

    public MyList()
    {
        _array = new T[2];
        Capacity = _array.Length;
        Count = 0;
    }

    public MyList(int length)
    {
        _array = new T[length];
        Capacity = length;
        Count = 0;
    }

    public MyList(int length, T element)
    {
        _array = new T[length];
        _array[0] = element;
        Capacity = length;
        Count = 1;
    }

    public void Add(T element)
    {
        if (Count >= Capacity)
        {
            Resize();
        }

        _array[Count] = element;
        Count++;
    }

    public void Add(T[] elements)
    {
        var requiredCapacity = Count + elements.Length;

        if (Capacity < requiredCapacity)
        {
            Resize(requiredCapacity);
        }

        foreach (var element in elements)
        {
            _array[Count] = element;
            Count++;
        }
    }

    public void Add(int index, T element)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за пределы допустимого диапазона.");
        }

        if (Count >= Capacity)
        {
            Resize();
        }

        for (var i = Count; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }

        _array[index] = element;
        Count++;
    }

    public void Add(int index, T[] elements)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за пределы допустимого диапазона.");
        }

        if (elements == null || elements.Length == 0)
        {
            return;
        }

        var requiredCapacity = Count + elements.Length;

        if (Capacity < requiredCapacity)
        {
            Resize(requiredCapacity);
        }

        for (var i = Count - 1; i >= index; i--)
        {
            _array[i + elements.Length] = _array[i];
        }

        for (var i = 0; i < elements.Length; i++)
        {
            _array[index + i] = elements[i];
        }

        Count += elements.Length;
    }

    public T this[int index]
    {
        get
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }
        set
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            _array[index] = value;
        }
    }

    private void Resize()
    {
        var newLength = Math.Max(_array.Length * 2, 1);
        _array = Copy(_array, newLength);
        Capacity = newLength;
    }

    private void Resize(int newLength)
    {
        var targetLength = Math.Max(newLength, _array.Length);
        _array = Copy(_array, targetLength);
        Capacity = targetLength;
    }

    private static T[] Copy(T[] sourceArray, int targetArrayLength)
    {
        if (targetArrayLength < sourceArray.Length)
        {
            throw new ArgumentException("Длина целевого массива не может быть меньше длины исходного массива.");
        }

        var targetArray = new T[targetArrayLength];

        for (var i = 0; i < sourceArray.Length; i++)
        {
            targetArray[i] = sourceArray[i];
        }

        return targetArray;
    }


    public void Sort()
    {
        if (Count <= 1) return;
        QuickSort(0, Count - 1);
    }

    private void QuickSort(int low, int high)
    {
        if (low < high)
        {
            var pivotIndex = Partition(low, high);
            QuickSort(low, pivotIndex - 1);
            QuickSort(pivotIndex + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        var pivot = _array[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (_array[j].CompareTo(pivot) <= 0)
            {
                i++;
                (_array[i], _array[j]) = (_array[j], _array[i]);
            }
        }

        (_array[i + 1], _array[high]) = (_array[high], _array[i + 1]);
        return i + 1;
    }
}