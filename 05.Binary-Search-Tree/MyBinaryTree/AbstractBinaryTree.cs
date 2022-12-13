﻿namespace MyBinaryTree
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
            throw new NotImplementedException();
        }

        public IEnumerable<IAbstractBinaryTree<T>> PreOrder()
        {
            var list = new List<IAbstractBinaryTree<T>>();
            list.Add(this);

            if (this.Left != null) list.AddRange(this.Left.PreOrder());

            if (this.Right != null) list.AddRange(this.Right.PreOrder());

            return list;
        }
    }
}
