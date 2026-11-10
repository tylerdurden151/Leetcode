/*
 Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.

 

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2
 
 */

Solution s = new Solution();
Console.WriteLine(s.SubarraySum(new int[] { 1, 1, 1 }, 2)); // Output: 2
Console.WriteLine(s.SubarraySum(new int[] { 1, 2, 3 }, 3)); // Output: 2
public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> prefixCounts = new();

        prefixCounts[0] = 1;

        int sum = 0;
        // This is the goal
        int count = 0;

        foreach (int num in nums)
        {
            // Step 1: Update running sum
            sum += num;

            // Step 2: Calculate the sum we need
            int target = sum - k;

            // Step 3: Check previous sums
            if (prefixCounts.ContainsKey(target))
            {
                count += prefixCounts[target];
            }

            // Step 4: Remember this running sum
            if (prefixCounts.ContainsKey(sum))
            {
                prefixCounts[sum]++;
            }
            else
            {
                prefixCounts[sum] = 1;
            }
        }

        return count;
    }
}

