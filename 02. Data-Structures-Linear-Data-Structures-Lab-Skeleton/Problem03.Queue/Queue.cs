namespace Problem03.Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Queue<T> : IAbstractQueue<T>
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

        private Node head;

        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            var currentNode = new Node(item);

            if (this.head == null)
            {
                this.head = currentNode;
            }
            else
            {
                var head = this.head;

                while (head.Next != null)
                {
                    head = head.Next;
                }

                head.Next = currentNode;
            }
            this.Count++;
        }

        public T Dequeue()
        {
            var element = this.CheckIfHeadIsNull();
            this.head = this.head.Next;

            this.Count--;
            return element;
        }

        public T Peek()
        {
            return this.CheckIfHeadIsNull();
        }

        public bool Contains(T item)
        {
            while (this.head != null)
            {
                if (this.head.Element.Equals(item))
                {
                    return true;
                }
                this.head = this.head.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        => this.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            while (this.head != null)
            {
                yield return this.head.Element;
                this.head = this.head.Next;
            }
        }

        private T CheckIfHeadIsNull()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            return this.head.Element;
        }
    }
}