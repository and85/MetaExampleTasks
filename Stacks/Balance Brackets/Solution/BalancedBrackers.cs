using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class BalancedBrackers
{
    static void Main(string[] args)
    {
        // Call isBalanced() with test cases here
    }

    // )
    public static bool IsBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        var openBraces = new Dictionary<char, char>()
        {
            { '}', '{' } ,
            { ')', '(' } ,
            { ']', '[' },
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (openBraces.ContainsValue(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                if (stack.Peek() != openBraces[s[i]])
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }
        }

        return stack.Count == 0;
    }
}