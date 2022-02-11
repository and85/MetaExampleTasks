public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public Node()
        {
            this.Data = 0;
            this.Left = null;
            this.Right = null;
        }
        public Node(int data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }

public class Solution
{
    public int VisibleNodes_Bfs(Node root)
    {
        int levels = 0;
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            levels++;
            int levelSize = queue.Count();

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        return levels;
    }

    private int _maxDepth = 0;
    public int VisibleNodes(Node root)
    {
        return Dfs(root, 0);
    }

    private int Dfs(Node root, int depth)
    {
        if (root == null) return depth;

        depth++;

        depth = Math.Max(Dfs(root.Left, depth), Dfs(root.Right, depth));

        _maxDepth = Math.Max(_maxDepth, depth);
        return depth;
    }
}