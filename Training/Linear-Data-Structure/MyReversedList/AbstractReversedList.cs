using System.Collections;

namespace MyReversedList
{
    public class AbstractReversedList<T> : IAbstractReversedList<T>
    {
        private T[] _items;
        private const int DEFAUL_CAPACITY = 4;

        public AbstractReversedList()
            :this(DEFAUL_CAPACITY)
        {
        }

        public AbstractReversedList(int capacity)
        {
            if (capacity < 0) throw new NullReferenceException();
            _items = new T[capacity];
        }

        public int Count { get; private set; }

        public T this[int index] 
        {
            get
            {
                ValidateIndex(index);
                return _items[Count - 1 - index];
            }
           
            set
            {
                ValidateIndex(index);
                _items[Count - 1 - index] = value;
            }
        }

        public void Add(T item)
        {
            Grow();
            _items[Count++] = item;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[Count -1 - i].Equals(item)) return i;
            }
            return -1;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item)) return true;
            }
            return false;
        }

        public bool Remove(T item)
        {
           var searchedItemIndex = IndexOf(item);
            if (searchedItemIndex == -1) return false;

            RemoveAt(searchedItemIndex);
            return true;
        }

        public void RemoveAt(int index)
        {  
            ValidateIndex(index);

            for (int i = Count - 1 - index; i < Count-1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _items[Count - 1] = default(T);
            Count--;
        }

        public void Insert(int index,T item)
        {
            ValidateIndex(index);
            Grow();

            //koce misho {anton} neli 

            // foreach => neli anton misho koce
                        
            for (int i = Count; i >  Count -index; i--)
            {
                _items[i] = _items[i - 1];
            }

            _items[Count - index] = item;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count; i > 0; i--)
            {
                yield return _items[i-1];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        private void Grow()
        {
            if(_items.Length == Count)
            {
                var coppyArray = new T[DEFAUL_CAPACITY * 2];
                Array.Copy(_items, coppyArray, _items.Length);
                _items = coppyArray;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
        }
    }
}
