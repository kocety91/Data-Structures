namespace MyBinarySearchTree
{
    public class AbstractBinarySearchTree<T> : IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        private class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }
        }

        private Node _root;

        public void EachInOrder(Action<T> action)
        {
            EachInOrderDfs(_root, action);
        }

        private void EachInOrderDfs(Node node, Action<T> action)
        {
            if (node == null) return;

            EachInOrderDfs(node.Left, action);
            action.Invoke(node.Value);
            EachInOrderDfs(node.Right, action);
        }
    }
}
