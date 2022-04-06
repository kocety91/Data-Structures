namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public Node Next { get; set; }

            public Node Previous { get; set; }
            public T Value { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }

        private Node head;

        private Node tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var currentNode = new Node(item);

            if (this.head  == null)
            {
                this.head = this.tail = currentNode;
            }
            else
            {
                var oldHead = this.head;
                oldHead.Previous = currentNode;
                this.head = currentNode;
                this.head.Next = oldHead;
            }
            this.Count++;
        }

        public void AddLast(T item)
        {
            var currentNode = new Node(item);

            if (this.tail == null)
            {
                this.head = this.tail = currentNode;
            }
            else
            {
                var oldTail = this.tail;
                oldTail.Next = currentNode;
                currentNode.Previous = oldTail;
                this.tail = currentNode;
            }
            this.Count++;
        }

        public T GetFirst()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }
            return this.head.Value;
        }

        public T GetLast()
        {
            if (this.tail == null)
            {
                throw new InvalidOperationException();
            }

           return this.tail.Value;
        }

        public T RemoveFirst()
        {
            var getFirst = this.GetFirst();

            if(this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.Next;
                this.head.Previous = null;
            }
            this.Count--;

            return getFirst;
        }

        public T RemoveLast()
        {
            var getLast = this.GetLast();

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.tail = this.tail.Previous;
                this.tail.Next = null;
            }
            this.Count--;

            return getLast;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while(this.head != null)
            {
                yield return this.head.Value;
                this.head = this.head.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
    }
}