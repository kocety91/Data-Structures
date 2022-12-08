namespace MyTree
{
    public interface ITree<T>
    {
        IEnumerable<T> OrderBfs();

        IEnumerable<T> OrderDfs();
    }
}
