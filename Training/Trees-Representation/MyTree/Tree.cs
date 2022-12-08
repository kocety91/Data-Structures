namespace MyTree
{
    public class Tree<T> : ITree<T>
    {
        private readonly List<Tree<T>> _children;
        private Tree<T> _parent;
        private T _value;

        public Tree(T value)
        {
            _value = value;
            _children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                child._parent = this;
                _children.Add(child);
            }
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            var queue = new Queue<Tree<T>>();
            var isFound = false;
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var tree = queue.Dequeue();
                if (tree._value.Equals(parentKey))
                {
                    tree._children.Add(child);
                    child._parent = tree;
                    isFound = true;
                    break;
                }

                foreach (var item in tree._children)
                {
                    queue.Enqueue(item);
                }
            }
            if (!isFound)
            {
                throw new ArgumentNullException($"No parentkey with this value:  {parentKey}");
            }
        }

        public void RemoveNode(T nodeKey)
        {
            var queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            if (this._value.Equals(nodeKey))
            {
                throw new ArgumentException("Cant delete root elemet !");
            }

            while (queue.Count >0)
            {
                var currentTree = queue.Dequeue();
                if (currentTree._value.Equals(nodeKey) 
                    || currentTree._value.Equals(nodeKey) && currentTree._children.Count >0)
                {
                    currentTree._parent._children.Remove(currentTree);
                }

                foreach (var child in currentTree._children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        public IEnumerable<T> OrderBfs()
        {
            var queue = new Queue<Tree<T>>();
            var result = new List<T>();

            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var subtree = queue.Dequeue();
                result.Add(subtree._value);

                foreach (var child in subtree._children)
                {
                    queue.Enqueue(child);
                }
            }
            return result;
        }

        public IEnumerable<T> OrderDfs()
        {
            var list = new List<T>();
            Dfs(this,list);

            return list;
        }

        private void Dfs(Tree<T> tree,IList<T> result)
        {
            foreach (var child in tree._children)
            {
                Dfs(child,result);
            }
            result.Add(tree._value);
        }
    }
}
