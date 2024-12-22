namespace MyCustomList

{
    public class MyList

    {
        private int[] _array;


        public int Capacity { get; set; }


        public int Count { get; set; }


        public MyList()

        {
            _array = new int[2];
            Capacity = _array.Length;
            Count = 0;
        }


        public MyList(int length)

        {
            _array = new int[length];
            Capacity = length;
            Count = 0;
        }


        public MyList(int length, int element)

        {
            _array = new int[length];
            _array[0] = element;
            Capacity = length;
            Count = 1;
        }


        public void Add(int element)

        {
            if (Count >= Capacity)
            {
                Resize();
            }

            _array[Count] = element;
            Count++;
        }


        //1 вариант
        public void Add(int[] elements)
        {
            if (Count + elements.Length > _array.Length)
            {
                while (Count + elements.Length > _array.Length)
                {
                    Resize();
                }
            }
            
            foreach (var element in elements)
            {
                _array[Count] = element;
                Count++;
            }
        }
        //2 вариант
        // public void Add(int[] elements)
        // {
        //     foreach (var element in elements)
        //     {
        //         Add(element);
        //     }
        // }

        public void Add(int index, int element)
        
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
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
        
        
        public void Add(int index, int[] elements)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
            }

            if (Count + elements.Length > Capacity)
            {
                while (Count + elements.Length > Capacity)
                {
                    Resize();
                }
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




        public int this[int index]

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
            var newLength = _array.Length * 2;
            var newArray = new int[newLength];

            Array.Copy(_array, newArray, Count);
            _array = newArray;
        }


        private void Copy(int[] sourceArray, int[] destinationArray)

        {
            if (sourceArray.Length > destinationArray.Length)

            {
                throw new ArgumentException();
            }


            for (int i = 0; i < sourceArray.Length; i++)

            {
                destinationArray[i] = sourceArray[i];
            }
        }
    }
}