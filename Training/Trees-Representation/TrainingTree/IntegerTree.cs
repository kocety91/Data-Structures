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
            var treeList = new List<Tree<int>>();
            var list = new List<Tree<int>>();
            GetSubtreesWithGivenSumDfs(this, list, treeList, sum);
            return list;
        }

        private void GetPathsWithDfs(Tree<int> tree, List<Stack<int>> list)
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

        private void GetSubtreesWithGivenSumDfs(Tree<int> tree, List<Tree<int>> list, List<Tree<int>> treeList, int sum)
        {
            foreach (var child in tree.Children)
            {
                if (tree.Parent == null) treeList.Clear();

                treeList.Add(child);

                if (treeList.Sum(x => x.Key) == sum)
                {
                    list.AddRange(treeList);
                    return;
                }

                GetSubtreesWithGivenSumDfs(child,list, treeList, sum) ;

                if (treeList.Sum(x => x.Key) == sum) return;
            }
        }
    }
}
