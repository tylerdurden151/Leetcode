/*3. Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.


Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

*/

Solution2 s2 = new Solution2();
int [] result2 = s2.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
Console.WriteLine(string.Join(",", result2));


// Loop thru and store in new array

public class Solution2
{
    public int[] MoveZeroes(int[] nums)
    {
        int pos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[pos];
                nums[pos] = nums[i];
                nums[i] = temp;
                pos++;
            }
        }
        return nums;
    }

}