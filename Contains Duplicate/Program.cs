/*
 Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:

Input: nums = [1,2,3,1]

Output: true

Example 2:

Input: nums = [1,2,3,4]

Output: false

Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]

Output: true
 */


using System;
Solution s = new Solution();
bool result1 = s.isTwice(new int[] { 1, 2, 3, 4, 5 });
bool result2 = s.isTwice(new int[] { 1, 2, 3, 1 });
bool result3 = s.isTwice(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);



public class Solution
{
    public bool isTwice(int[] num)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int i in num)
        {
            // If the number is already in the set, it means it has appeared twice
            if (!seen.Add(i))
            {
                return true;
            }
        }
        return false;
    }

}