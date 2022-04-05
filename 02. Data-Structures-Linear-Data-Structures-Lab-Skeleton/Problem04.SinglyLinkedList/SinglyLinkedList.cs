namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
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

        public void AddFirst(T item)
        {
            var currentNode = new Node(item);

            if (this.head == null)
            {
                this.head = currentNode;
            }
            else
            {
                var oldHead = this.head;

                currentNode.Next = oldHead;
                this.head = currentNode;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            var currentNode = new Node(item);

            if (this.head == null)
            {
                this.head = currentNode;
            }
            else
            {
                var oldHead = this.head;

                while(oldHead.Next != null)
                {
                    oldHead = oldHead.Next;
                }

                oldHead.Next = currentNode;
            }

            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        => this.GetEnumerator();

        public T GetFirst()
        {
            return this.CheckIfHeadIsNull();
        }

        public T GetLast()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            var oldHead = this.head;

            while (oldHead.Next != null)
            {
                oldHead = oldHead.Next;
            }

            var element = oldHead.Element;

            return element;
        }

        public T RemoveFirst()
        {
            var element = this.CheckIfHeadIsNull();

            this.head = this.head.Next;
            this.Count--;
            return element;
        }

        public T RemoveLast()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            var oldHead = this.head;

            while (oldHead.Next != null)
            {
                oldHead = oldHead.Next;
            }

            var element = oldHead.Element;

            this.Count--;
            return element;
        }

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