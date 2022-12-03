using System.Collections;

namespace MyQueue
{
    public class AbstractQueue<T> : IAbstractQueue<T>
    {
        private Node _head;

        private class Node
        {
            public Node(T element)
            {
                Element = element;
            }
            public Node(T element, Node next)
            {
                Element = element;
                Next = next;
            }

            public T Element { get; set; }

            public Node Next { get; set; }
        }

        public int Count { get; set; }

        public void Enqueue(T item)
        {
            if (_head == null)
            {
                _head =  new Node(item);
            }
            else
            {
                var  node = _head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Node(item);
            }
            Count++;
        }

        public T Dequeue()
        {
            ValidateHead();

            var element = _head.Element;
            _head = _head.Next;

            Count--;
            return element;
        }

        public T Peek()
        {
            ValidateHead();
            return _head.Element;
        }

        public bool Contains(T item)
        {
            while (_head != null)
            {
                if (_head.Element.Equals(item)) return true;
                _head = _head.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (_head != null)
            {
                yield return _head.Element;
                _head = _head.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private void ValidateHead()
        {
            if (_head == null) throw new NullReferenceException();
        }
    }
}
