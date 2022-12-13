namespace MyBinaryTree
{
    public interface IAbstractBinaryTree<T>
    {

        public IAbstractBinaryTree<T> Right { get; }

        public IAbstractBinaryTree<T> Left { get; }

        public T Value { get;}

        void ForEachInOrder(Action<T> action);

        string AsIndentedPreOrder(int indent);

        IEnumerable<IAbstractBinaryTree<T>> PreOrder();

        IEnumerable<IAbstractBinaryTree<T>> InOrder();

        IEnumerable<IAbstractBinaryTree<T>> PostOrder();

    }
}
