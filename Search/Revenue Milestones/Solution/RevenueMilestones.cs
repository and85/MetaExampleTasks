using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class RevenueMilestones {
  static void Main(string[] args) {
    // Call getMilestoneDays() with test cases here
  }
  
  public static int[] GetMilestoneDays(int[] revenues, int[] milestones) 
  {
        int[] days = new int[milestones.Length];
        Array.Fill(days, -1);

        int curRevenue = 0;
        for (int i = 0, m = 0; i < revenues.Length && m < milestones.Length; i++)
        {
            curRevenue += revenues[i];
            
            while (m < milestones.Length && milestones[m] <= curRevenue)
            {
                days[m] = i + 1;
                m++;
            }
            
        }

        return days;
    }
}