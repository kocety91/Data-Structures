namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private class Node
        {
            public T Element { get; set; }

            public Node Next { get; set; }

            public Node()
            {
            }
            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public Node(T element)
                : this(element, null)
            {
            }
        }

        private Node top;

        public int Count { get; private set; }

        public void Push(T item)
        {
            var currentNode = new Node(item);
            currentNode.Next = this.top;

            this.top = currentNode;
            this.Count++;
        }

        public T Pop()
        {
            var topNode = this.CheckIfTopIsNull();
            this.top = this.top.Next;

            this.Count--;
            return topNode;
        }

        public T Peek()
        {
            return this.CheckIfTopIsNull();
        }

        public bool Contains(T item)
        {
            while (this.top !=null)
            {
                if (this.top.Element.Equals(item))
                {
                    return true;
                }

                this.top = this.top.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        => this.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            while (this.top != null)
            {
                yield return this.top.Element;
                this.top = this.top.Next;
            }
        }

        private T CheckIfTopIsNull()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException();
            }

            return this.top.Element;
        }
    }
}