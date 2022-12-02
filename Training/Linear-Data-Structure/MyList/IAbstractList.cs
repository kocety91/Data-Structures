namespace MyList
{
    public interface IAbstractList<T> : IEnumerable<T>
    {
        T this[int index] { get; set; }

        void Add(T item);

        int IndexOf(T item);

        bool Contains(T item);

        void Insert(int index, T item);

        void RemoveAt(int index);

        bool Remove(T item);
    }
}
