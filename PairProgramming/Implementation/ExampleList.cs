namespace Implementation
{
    public class ExampleList
    {
        private const int BUFFER_SIZE = 10;
        private int[] _items = new int[BUFFER_SIZE];
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements contained in the List.
        /// </summary>
        /// <returns>The number of elements contained in the List.</returns>
        public int Count
        {   
            get
            {
                return _count;
            }
        }

        /// <summary>
        /// Adds an object to the end of the List.
        /// </summary>
        /// <param name="item">The object to be added to the end of the List.</param>
        public void Add(int item)
        {
            if (_items.Length == _count)
            {
                int[] items = new int[_items.Length + BUFFER_SIZE];

                for (int cnt = 0; cnt < _count; cnt++)
                {
                    items[cnt] = _items[cnt];
                }

                _items = items;
            }

            _items[_count] = item;
            _count++;
        }

        /// <summary>
        /// Removes all elements from the List.
        /// </summary>
        public void Clear()
        {
            _items = new int[BUFFER_SIZE];
            _count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the List.
        /// </summary>
        /// <param name="item">The object to locate in the List.</param>
        /// <returns>true if item is found in the List; otherwise, false.</returns>
        public bool Contains(int item)
        {
            int index = IndexOf(item);

            if (index < 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first occurrence within the entire List.
        /// </summary>
        /// <param name="item">The object to locate in the List.</param>
        /// <returns>The zero-based index of the first occurrence of item within the entire List, if found; otherwise, -1.</returns>
        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i] == item)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Inserts an element into the List at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        /// <throws>ArgumentOutOfRangeException if index is less than 0 -or- index is equal to or greater than Count.</throws>
        public void Insert(int index, int item)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index));

            int newSize = _items.Length;

            if (newSize == _count)
                newSize += BUFFER_SIZE;

            int[] items = new int[newSize];

            int currLocation = 0;

            for (int cnt = 0; cnt < _count; cnt++)
            {
                if (currLocation == index)
                {
                    items[currLocation] = item;
                    currLocation++;
                }

                items[currLocation] = _items[cnt];
                currLocation++;
            }

            _items = items;
            _count++;
        }

        /// <summary>
        /// Removes the element at the specified index of the List.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <throws>ArgumentOutOfRangeException if index is less than 0 -or- index is equal to or greater than Count.</throws>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index));

            int[] items = new int[_items.Length];
            int currLocation = 0;

            for (int i = 0; i < _count; i++)
            {
                if (i != index)
                {
                    items[currLocation] = _items[i];
                    currLocation++;
                }
            }

            _items = items;
            _count++;
        }

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        /// <throws>ArgumentOutOfRangeException if index is less than 0 -or- index is equal to or greater than Count.</throws>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                _items[index] = value;
            }
        }
    }
}
