/*
 Given an integer array nums sorted in non-decreasing order, 
return an array of the squares of each number sorted in non-decreasing order.
 
Example 1:
Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].

Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 */

Solution s = new Solution();    
s.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
s.SortedSquares(new int[] { -7, -3, 2, 3, 11 });


public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        //Declaure pointers and return result
        int left = 0;
        int right = nums.Length - 1;
        int[] result = new int[nums.Length];

        // Loop thru the right pos and increment down
        for (int pos = nums.Length - 1; pos >= 0; pos--)
        {
            //Store and Square the pointers
            int leftSq = nums[left] * nums[left];
            int rightSq = nums[right] * nums[right];

            //Sort the square points
            if (leftSq > rightSq)
            {
                //Store the higher Square into the results array
                result[left] = leftSq;
                //increment up 
                left++;
            }
            else
            {
                //Store the higher Square into the results array
                result[right] = rightSq;
                //increment up 
                right--;
            }

        }
        return result;
    }
}