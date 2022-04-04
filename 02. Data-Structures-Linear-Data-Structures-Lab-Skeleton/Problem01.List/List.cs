namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] items;

        public List()
            : this(DEFAULT_CAPACITY)
        {
        }

        public List(int capacity)
        {
            if (capacity < 0)
            {
                throw new IndexOutOfRangeException(nameof(capacity));
            }

            this.items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }

            set
            {
                ValidateIndex(index);
                items[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            Grow();

            this.items[this.Count++] = item;
        }

        public bool Contains(T item)
        => this.IndexOf(item) == -1 ? false : true;

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {

            ValidateIndex(index);
            Grow();

            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = items[i - 1];
            }

            this.items[index] = item;
            this.Count++;

        }

        public bool Remove(T item)
        {
            var existIndex = this.IndexOf(item);

            if (existIndex == -1)
            {
                return false;
            }

            this.RemoveAt(existIndex);
            return true;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[this.items.Length - 1] = default;
            this.Count--;
        }


        private void Grow()
        {
            if (this.Count == this.items.Length)
            {
                var newArray = new T[this.items.Length * 2];

                for (int i = 0; i < this.items.Length; i++)
                {
                    newArray[i] = this.items[i];
                }
                this.items = newArray;
            }
        }

        private void ValidateIndex(int index)
        {
            if (this.Count <= index || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}