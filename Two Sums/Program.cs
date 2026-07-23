/*
 3. Given an array of integers nums and an integer target, return indices of the two numbers 
such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input: nums = [2,7,11,15], target = 9

Output: [0,1]

Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 */

Solution s = new Solution();

try
{
    int[] result = s.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
    Console.WriteLine($"Indices: {result[0]}, {result[1]}");

    int[] result2 = s.TwoSum(new int[] { 2, 7, 11, 15 }, 100);
    Console.WriteLine($"Indices: {result2[0]}, {result2[1]}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"No solution: {ex.Message}");
}


public class Solution
{
    //Big O(n) solution using a dictionary to store the complement 
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            // Check if the complement exists in the dictionary
            //Compare the missing number with the current number in the array
            if (map.ContainsKey(complement))
            {
                // If it exists, return the indices of the two numbers [0, 1]
                // or [complement index, current index i]
                return new int[] { map[complement], i };
            }
            // If it doesn't exist, add the current number
            // and its index to the dictionary
            map[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }

}