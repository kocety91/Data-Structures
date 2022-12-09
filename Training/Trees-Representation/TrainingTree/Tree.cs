using System.Text;

namespace TrainingTree
{
    public class Tree<T> : IAbstractTree<T>
    {
        private List<Tree<T>> _children;

        public Tree(T key)
        {
            Key = key;
            _children = new List<Tree<T>>();
        }

        public Tree(T key, params Tree<T>[] children)
            :this(key)
        {
            foreach (var child in children)
            {
                _children.Add(child);
            }
        }

        public T Key { get; private set; }

        public Tree<T> Parent { get; private set; }

        public IReadOnlyCollection<Tree<T>> Children => _children.AsReadOnly();

        public void AddChild(Tree<T> child)
        {
            throw new NotImplementedException();
        }

        public void AddParent(Tree<T> parent)
        {
            throw new NotImplementedException();
        }

        public string AsString()
        {
            var sb = new StringBuilder();
            int counter = 0;
            SetStringBuilder(this, sb,ref counter);
            return sb.ToString();
        }

        public IEnumerable<T> GetInternalKeys()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetLeafKeys()
        {
            throw new NotImplementedException();
        }

        public T GetDeepestKey()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetLongestPath()
        {
            throw new NotImplementedException();
        }

        private void SetStringBuilder(Tree<T> tree , StringBuilder sb,ref int counter)
        {
            sb.AppendLine(new string(' ',counter) + tree.Key.ToString());

            foreach (var child in tree.Children)
            {
                counter += 2;
                SetStringBuilder(child, sb,ref counter);
            }
            counter -= 2;
        }
    }
}
