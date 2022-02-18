using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class ForeignCurrency
{
    static void Main(string[] args)
    {
        // Call canGetExactChange() with test cases here
    }

    public static bool canGetExactChange(int targetMoney, int[] denominations)
    {
        Array.Sort(denominations);
        Array.Reverse(denominations);

        Recursion(targetMoney, denominations, new List<int>());

        return _can;
    }

    private static bool _can = false;
    public static void Recursion(int targetMoney, int[] denominations, List<int> ignored)
    {
        for (int dd = 0; dd < denominations.Length; dd++)
        {
            int d = denominations[dd];

            if (ignored.Contains(d)) continue;

            if (d > targetMoney) return;

            if (targetMoney % d == 0)
            {
                _can = true;
                return;
            }

            int div = targetMoney / d;

            var list = new List<int>(ignored);
            list.Add(d);
            for (int i = 1; i <= div; i++)
            {
                
                Recursion(targetMoney - d * i, denominations, list);                
            }

            Recursion(targetMoney, denominations, list);
        }
    }
}