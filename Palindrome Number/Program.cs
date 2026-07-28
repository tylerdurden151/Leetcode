/*
 * 
 * Given an integer x, return true if x is a palindrome, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1
 */


Solution s = new Solution();
bool result = s.IsPalindrome(121);
Console.WriteLine($"{result}");

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int original = x;
        long reversed = 0;

        while (x > 0)
        {
            // Get the last digit of x "right pointer"
            int digit = x % 10;
            // Append the digit to the reversed number "left pointer"
            reversed = reversed * 10 + digit;
            // Remove the last digit from x
            x /= 10;
        }
        //Compare the reversed number with the original number
        return reversed == original;

    }
}