/*
 You have a long flowerbed in which some of the plots are planted, 
and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, 
where 0 means empty and 1 means not empty, and an integer n, 
return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false*/

Solution s = new Solution();
Console.WriteLine(s.canPlaceFlower(new int[] { 1, 0, 0, 0, 1 }, 1));
Console.WriteLine(s.canPlaceFlower(new int[] { 1, 0, 0, 0, 1 }, 2));



public class Solution
{
    public bool canPlaceFlower(int[] nums, int n)
    {
        //declare pointers
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                // Check if the left and right plots are empty.
                bool emptyLeftPlot = (i == 0) || (nums[i - 1] == 0);
                bool emptyRightPlot = (i == nums.Length - 1) || (nums[i + 1] == 0);

                //If both plots are empty, plant a flower and increment the count.
                if (emptyLeftPlot && emptyRightPlot)
                {
                    nums[i] = 1; // Plant a flower
                    count++;
                }
            }
        }
        return count >= n;
    }
}