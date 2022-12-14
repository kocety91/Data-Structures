namespace MyBinarySearchTree
{
    public interface IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        void EachInOrder(Action<T> action);

        void Insert(T item);

        IAbstractBinarySearchTree<T> Search(T item);
    }
}
