namespace MyBinarySearchTree
{
    public interface IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        void EachInOrder(Action<T> action);

        void Insert(T item);

        IAbstractBinarySearchTree<T> Search(T item);

        IEnumerable<T> Range(T firstItem, T secondItem);

        bool Contains(T item);

        void DeleteMin();

        void DeleteMax();

        void Delete(T item);

        int Counter();

        int Rank(T item);

        T Floor(T item);
    }
}
