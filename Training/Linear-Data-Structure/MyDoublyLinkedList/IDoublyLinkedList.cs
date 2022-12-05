namespace MyDoublyLinkedList
{
    public interface IDoublyLinkedList<T> : IEnumerable<T>
    {
        void AddFrst(T item);

        void AddLast(T item);

        T GetFirst();

        T GetLast();

        T RemoveFirst();

        T RemoveLast();
    }

}
