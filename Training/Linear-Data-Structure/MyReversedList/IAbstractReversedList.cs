namespace MyReversedList
{
    public interface IAbstractReversedList<T> :IEnumerable<T>
    {
        void Add(T item);   

        bool Contains(T item);

        int IndexOf(T item);

        void RemoveAt(int index);

        bool Remove(T item);

        void Insert(int index, T item);

        T this[int index] { get; set; }
    }
}
