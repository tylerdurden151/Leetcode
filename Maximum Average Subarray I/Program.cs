/*
 You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value.
Any answer with a calculation error less than 10-5 will be accepted.

Example 1:
Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

Example 2:
Input: nums = [5], k = 1
Output: 5.00000
 */

Solution s = new Solution();
double result1 = s.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
double result2 = s.FindMaxAverage(new int[] { 5 }, 1);
Console.WriteLine($"{result1}");
Console.WriteLine($"{result2}");

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        //Declare Pointers, current Sum, and a Max Sum
        int left = 0;
        int currSum = 0;
        int maxSum = int.MinValue;

        //Loop thru right pointer subarray window
        for (int right = 0; right < nums.Length; right++)
        {
            //take current right pointer and store into current Sum
            currSum += nums[right];

            if (right - left + 1 == k)
            {
                //compare the highest sum and store in maxSum
                maxSum = Math.Max(maxSum, currSum);
                //remove left pointer from currSum
                currSum -= nums[left];
                //increment left up
                left++;
            }
        }
        //return Average Max
        return (double)maxSum / k;
    }
}