namespace MyTree
{
    public interface ITree<T>
    {
        IEnumerable<T> OrderBfs();

        IEnumerable<T> OrderDfs();

        void AddChild(T parentKey, Tree<T> child);

        void RemoveNode(T nodeKey);
    }
}