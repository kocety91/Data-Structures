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

        public void Insert(T item)
        {
            _root = SetInsertPreOrder(_root, item);
        }

        private void EachInOrderDfs(Node node, Action<T> action)
        {
            if (node == null) return;

            EachInOrderDfs(node.Left, action);
            action.Invoke(node.Value);
            EachInOrderDfs(node.Right, action);
        }

        private Node SetInsertPreOrder(Node node, T item)
        {
            if (node is null) node = new Node(item);

            if (node.Value.CompareTo(item) > 0)
            {
                node.Left = SetInsertPreOrder(node.Left, item);
            }
            else if(node.Value.CompareTo(item) < 0)
            {
                node.Right = SetInsertPreOrder(node.Right, item);
            }

            return node;
        }
    }
}
