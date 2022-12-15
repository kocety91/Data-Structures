namespace MyBinarySearchTree
{
    public interface IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        void EachInOrder(Action<T> action);

        void Insert(T item);

        IAbstractBinarySearchTree<T> Search(T item);

        bool Contains(T item);

        void DeleteMin();

        void DeleteMax();

        void Delete(T item);

        int Counter();

        int Rank(T item);


    }
}
