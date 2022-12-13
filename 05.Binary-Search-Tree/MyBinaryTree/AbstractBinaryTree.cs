using System.Text;

namespace MyBinaryTree
{
    public class AbstractBinaryTree<T> : IAbstractBinaryTree<T>
    {
        public AbstractBinaryTree(T element)
        {
            Value = element;
        }

        public AbstractBinaryTree(T element, IAbstractBinaryTree<T> left, IAbstractBinaryTree<T> right)
            :this(element)
        {
            Left = left;
            Right = right;
        }

        public IAbstractBinaryTree<T> Right { get;private set; }

        public IAbstractBinaryTree<T> Left { get; private set; }

        public T Value { get ; private set; }

        public string AsIndentedPreOrder(int indent)
        {
            var sb = new StringBuilder();
            SetIndententionWithPreOrder(this, sb, indent);

            return sb.ToString();
        }

        public void ForEachInOrder(Action<T> action)
        {
           if(this.Left != null)  this.Left.ForEachInOrder(action);

            action.Invoke(this.Value);

           if(this.Right != null) this.Right.ForEachInOrder(action);
        }

        public IEnumerable<IAbstractBinaryTree<T>> InOrder()
        {
            var list = new List<IAbstractBinaryTree<T>>();
           
            if (this.Left != null) list.AddRange(this.Left.InOrder());

            list.Add(this);

            if (this.Right != null) list.AddRange(this.Right.InOrder());

            return list;
        }

        public IEnumerable<IAbstractBinaryTree<T>> PostOrder()
        {
            var list = new List<IAbstractBinaryTree<T>>();

            if(this.Left != null) list.AddRange(this.Left.PostOrder());

            if (this.Right != null) list.AddRange(this.Right.PostOrder());

            list.Add(this);
            return list;
        }

        public IEnumerable<IAbstractBinaryTree<T>> PreOrder()
        {
            var list = new List<IAbstractBinaryTree<T>>();
            list.Add(this);

            if (this.Left != null) list.AddRange(this.Left.PreOrder());

            if (this.Right != null) list.AddRange(this.Right.PreOrder());

            return list;
        }

        private void SetIndententionWithPreOrder(IAbstractBinaryTree<T> tree, StringBuilder sb, int indent)
        {
            sb.AppendLine(new string(' ', indent) + tree.Value.ToString());

            indent = tree.Left == null && tree.Right == null ? indent -= 2 : indent += 2;

            if (tree.Left != null) SetIndententionWithPreOrder(tree.Left, sb, indent);

            if (tree.Right != null) SetIndententionWithPreOrder(tree.Right, sb, indent);
        }
    }
}
