/*
 Write a function that reverses a string. The input string is given as an array of characters s.
You must do this by modifying the input array in-place with O(1) extra memory.

Example 1:
Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

Example 2:
Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]
 */
Solution s = new Solution();
s.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });

public class Solution
{
    public void ReverseString(char[] s)
    {
        //Declare pointers
        int left = 0;
        int right = s.Length - 1;

        //Compare the pointers
        while (left < right)
        {
            //create temp pointer
            char temp = s[left];
            //swap pointers
            s[left] = s[left];
            s[right] = temp;
            //increment
            left++;
            right--;
        }
        //Print Array
        Array.ForEach(s, Console.WriteLine);
    }
}