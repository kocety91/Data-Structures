using System.Collections;

namespace MyLinkedList
{
    public class AbstractLinkedList<T> : IAbstractLinkedList<T>
    {
        private Node _head;
        private class Node
        {
            public Node(T element)
            {
                Element = element;
            }
            public Node(T element,Node next)
                :this(element)
            {
                Next = next;
            }

            public T Element { get; set; }

            public Node Next { get; set; }
        }

        public int Count { get; set; }

        public void AddFirst(T item)
        {
            var node = new Node(item, _head);
            _head = node;

            Count++;
        }

        public void AddLast(T item)
        {
            if (_head == null)
            {
                _head = new Node(item);
            }
            else
            {
                var node = _head;
                while(node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Node(item);
            }
            Count++;
        }

        public T RemoveFirst()
        {
            ValidateHead();

            var element = _head.Element;
            _head = _head.Next;
            Count--;
            return element;
        }

        public T RemoveLast()
        {
            ValidateHead();

            if(_head.Next == null)
            {
                RemoveFirst();
            }

            var node = _head;

            while (node.Next.Next != null)
            {
                node = node.Next;
            }

            var element = node.Next.Element;
            node.Next = null;
            Count--;
            return element;
            
        }

        public T GetFirst()
        {
            ValidateHead();
            return _head.Element;
        }

        public T GetLast()
        {
            ValidateHead();

            var node = _head;   

            while (node.Next != null)
            {
                node = node.Next;
            }

            return node.Element;
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
            if (_head == null) throw new ArgumentNullException();
        }
    }
}
