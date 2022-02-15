public class Solution
{
    public class Node 
    {

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }

        public int Data { get; set; }
        public Node Next { get; set; }
    }

    // o(n) time, O(n) space
    // TODO: solve in O(space) without using a stack (e.g. reverse pointers of even nodes)
    public Node Reverse(Node head)
    {
        var sentinelHead = new Node(-1, head);

        var readP = sentinelHead;
        var writeP = readP;
        var stack = new Stack<Node>();

        while (readP != null)
        {
            if (readP.Data % 2 == 0)
            {
                stack.Push(readP);
            }
            else
            {                
                while (stack.Count > 0)
                {
                    var node = stack.Pop();
                    writeP.Next = node;
                    writeP = writeP.Next;

                    if (stack.Count == 0)
                    {
                        writeP.Next = readP;
                    }
                }
                

                writeP = readP;
            }

            readP = readP.Next;
        }
        
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            writeP.Next = node;
            writeP = writeP.Next;

            if (stack.Count == 0)
            {
                writeP.Next = null;
            }
        }        

        return sentinelHead.Next;
    }
}