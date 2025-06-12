// using System;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int actual = 0;
        int expected = n * (n + 1) / 2;

        foreach (int nm in nums)
        {
            actual += nm;
        }
        return expected - actual;
    }
}


