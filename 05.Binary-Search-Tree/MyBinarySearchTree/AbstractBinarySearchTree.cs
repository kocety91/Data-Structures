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

        public AbstractBinarySearchTree()
        {
        }

        private AbstractBinarySearchTree(Node node)
        {
            PreOrderCopy(node);
        }

        public void EachInOrder(Action<T> action)
        {
            EachInOrderDfs(_root, action);
        }


        public void Insert(T item)
        {
            _root = SetInsertPreOrder(_root, item);
        }

        public void DeleteMin()
        {
            if (_root == null) throw new InvalidOperationException();

            var node = _root;

            while (node.Left.Left != null)
            {
                node = node.Left;
            }

            node.Left = null;
        }

        public void DeleteMax()
        {
            if(_root == null) throw new InvalidOperationException();
            var node = _root;

            while (node.Right.Right != null)
            {
                node = node.Right;
            }

            node.Right = null;
        }


        public IAbstractBinarySearchTree<T> Search(T item)
        {
            var node = GetSearchedNode(_root, item);
            if (node == null) return null;
            var tree = new AbstractBinarySearchTree<T>(node);

            return tree;
        }

        public bool Contains(T item)
        {
            return Search(item) == null ? false : true;
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
            else if (node.Value.CompareTo(item) < 0)
            {
                node.Right = SetInsertPreOrder(node.Right, item);
            }

            return node;
        }

        private Node GetSearchedNode(Node node, T item)
        {
            if (node is null) return null;
            if (node.Value.Equals(item)) return node;

            if (node.Value.CompareTo(item) > 0) node = GetSearchedNode(node.Left, item);
            if (node.Value.CompareTo(item) < 0) node = GetSearchedNode(node.Right, item);

            return node;
        }

        private void PreOrderCopy(Node node)
        {
            if (node is null) return;

            Insert(node.Value);
            PreOrderCopy(node.Left);
            PreOrderCopy(node.Right);
        }
    }
}
