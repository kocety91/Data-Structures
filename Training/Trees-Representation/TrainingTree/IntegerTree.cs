namespace TrainingTree
{
    public class IntegerTree : Tree<int>, IIntegerTree
    {
        public IntegerTree(int key, params Tree<int>[] children)
            : base(key, children)
        {
        }

        public IEnumerable<IEnumerable<int>> GetPathsWithGivenSum(int sum)
        {
            var list = new List<Stack<int>>();

            GetPathsWithDfs(this, list);

            list = list.Where(x => x.Sum(y => y) == sum).ToList();
            return list;
        }

        public IEnumerable<Tree<int>> GetSubtreesWithGivenSum(int sum)
        {
            throw new NotImplementedException();
        }

        private void GetPathsWithDfs(Tree<int> tree,List<Stack<int>> list)
        {
            foreach (var child in tree.Children) 
            {
                GetPathsWithDfs(child, list);
            }
            var currentStack = new Stack<int>();

            while (tree.Parent != null)
            {
                currentStack.Push(tree.Key);
                tree = tree.Parent;
            }

            currentStack.Push(tree.Key);
            list.Add(currentStack);
        }
    }
}
