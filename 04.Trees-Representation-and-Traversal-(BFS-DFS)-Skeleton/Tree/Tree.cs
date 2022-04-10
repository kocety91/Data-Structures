namespace Tree
{
    using System;
    using System.Collections.Generic;

    public class Tree<T> : IAbstractTree<T>
    {
        private T value;
        private Tree<T> parent;
        private List<Tree<T>> children;

        public Tree(T value)
        {
            this.value = value;
            this.children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                child.parent = this;
                this.children.Add(child);
            }
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> OrderBfs()
        {
            var queue = new Queue<Tree<T>>();
            var list = new List<T>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var subtree = queue.Dequeue();

                foreach (var element in subtree.children)
                {
                    queue.Enqueue(element);
                }

               list.Add(subtree.value);
            }

            return list;
        }

        public IEnumerable<T> OrderDfs()
        {
            var stack = new Stack<Tree<T>>();
            stack.Push(this);
            var result = new Stack<T>();

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                foreach (var child in node.children)
                {
                    stack.Push(child);
                }
                result.Push(node.value);
            }
            return result;
        }

        public void RemoveNode(T nodeKey)
        {
            throw new NotImplementedException();
        }

        public void Swap(T firstKey, T secondKey)
        {
            throw new NotImplementedException();
        }
    }
}
