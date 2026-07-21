/*
1929. Concatenation of Array

Given an integer array nums of length n, 
you want to create an array ans of length 2n where ans[i] == nums[i] 
and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

Specifically, ans is the concatenation of two nums arrays.

Return the array ans.
 */
int[] value = { 1, 2, 1 };
int[] value2 = { 1, 3, 2, 1 };
Solution s = new Solution();
Console.WriteLine(string.Join(", ", s.GetConcatenation(value))); 
Console.WriteLine(string.Join(", ", s.GetConcatenation(value2))); ;


public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] result = new int[nums.Length * 2];
        int i = 0;
        foreach (int n in nums)
        {
            result[i] = n;
            result[i + nums.Length] = n;
            i++;
        }
        return result;
    }
}