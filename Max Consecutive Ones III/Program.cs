/*
 Given a binary array nums and an integer k, return the maximum number of 
consecutive 1's in the array if you can flip at most k 0's.

Example 1:
Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
Output: 6
Explanation: [1,1,1,0,0,1,1,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

Example 2:
Input: nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
Output: 10
Explanation: [0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

 */
Solution s = new Solution();
int result1 = s.LongestOnes(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2);
int result2 = s.LongestOnes(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3);
Console.WriteLine($"{result1}");
Console.WriteLine($"{result2}");

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        //declare left pointer, current value, and result
        int left = 0;
        int curr = 0;
        int result = 0;

        //loop thru the right pointer, incrementing up
        for (int right = 0; right < nums.Length; right++)
        {
            //check the right pointer if it is 0.
            if (nums[right] == 0)
            {
                //if it is, add +1 to current
                curr++;
            }
            while (curr > k)
            {
                if (nums[left] == 0)
                {
                    curr--;
                }
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}