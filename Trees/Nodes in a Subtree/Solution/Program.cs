namespace metaexamples
{
    class Program
    {

        public class Node
        {
            public int val;
            public List<Node> children;

            public Node()
            {
                val = 0;
                children = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                children = new List<Node>();
            }

            public Node(int _val, List<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public class Query
        {
            public int U { get; set; }
            public char C { get; set; }
            public Query(int u, char c)
            {
                this.U = u;
                this.C = c;
            }
        }

        public static int[] CountOfNodes(Node root, List<Query> queries, String s)
        {
            int[] result = new int[queries.Count];
            int counter = 0;
            foreach (var q in queries)
            {
                result[counter] = CountOfSimilarNodes(root, q.U, q.C, s);
            }


            return result;
        }

        private static int CountOfSimilarNodes(Node root, int u, char c, string s)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.val == u) return CountOfSimilarNodes(node, s);

                foreach (var child in node.children)
                {                    
                    queue.Enqueue(child);
                }
            }

            return -1;
        }

        private static int CountOfSimilarNodes(Node root, string s)
        {
            int result = 0;
            char c = s[root.val - 1];

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                
                if (s[node.val - 1] == c) result++;

                foreach (var child in node.children)
                {                    
                    queue.Enqueue(child);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Testcase 1
            int n_1 = 3, q_1 = 1;
            string s_1 = "aba";
            Node root_1 = new Node(1);
            root_1.children.Add(new Node(2));
            root_1.children.Add(new Node(3));
            List<Query> queries_1 = new List<Query>();
            queries_1.Add(new Query(1, 'a'));
            int[] output_1 = CountOfNodes(root_1, queries_1, s_1);
            int[] expected_1 = { 2 };
            

            // Testcase 2
            // Testcase 2fgg
            int n_2 = 7, q_2 = 3;
            String s_2 = "abaacab";
            Node root_2 = new Node(1);
            root_2.children.Add(new Node(2));
            root_2.children.Add(new Node(3));
            root_2.children.Add(new Node(7));
            root_2.children[0].children.Add(new Node(4));
            root_2.children[0].children.Add(new Node(5));
            root_2.children[1].children.Add(new Node(6));
            List<Query> queries_2 = new List<Query>();
            queries_2.Add(new Query(1, 'a'));
            queries_2.Add(new Query(2, 'b'));
            queries_2.Add(new Query(3, 'a'));
            int[] output_2 = CountOfNodes(root_2, queries_2, s_2);
            int[] expected_2 = { 4, 1, 2 };
            Console.WriteLine();
        }
    }
}