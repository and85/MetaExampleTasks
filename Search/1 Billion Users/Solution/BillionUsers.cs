using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class BillionUsers
{
    static void Main(string[] args)
    {        
    }

    private const float TargetUsers = 1_000_000_000;    

    // o(logN) - time complexity
    public static int GetBillionUsersDay(float[] growthRates)
    {
        int day = 1, prevDay = 1;
        float users = 0;

        do
        {            
            users = CountUsers(growthRates, day);

            if (users > TargetUsers)
            {
                return BinarySearch(growthRates, prevDay, day);                
            }
            else
            {
                prevDay = day;
                day *= 2;
            }
            
        }
        while (users < TargetUsers);

        return 0;
    }

    private static int BinarySearch(float[] growthRates, int prevDay, int day)
    {
        int l = prevDay, h = day;

        while (l < h)
        {
            int m = l + (h - l) / 2;

            float curUsers = CountUsers(growthRates, m);            

            if (curUsers < TargetUsers)
            {
                l = m + 1;
            }
            else if (curUsers >= TargetUsers)
            {                
                h = m ;
            }            
        }

        return l;
    }

    private static float CountUsers(float[] growthRates, int day)
    {
        float users = 0;
        foreach (var rate in growthRates)
        {
            users += (float)Math.Pow(rate, day);
        }

        return users;
    }


    // O(n) - time complexity
    public static int GetBillionUsersDay_BruteForce(float[] growthRates)
    {
        float users = 0;
        int day = 0;

        do
        {            
            users = CountUsers(growthRates, ++day);
        }
        while (users < TargetUsers);


        return day;
    }
}