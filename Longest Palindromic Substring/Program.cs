/*
 5. Longest Palindromic Substring
Solved
Medium
Topics
conpanies icon
Companies
Hint
Given a string s, return the longest palindromic substring in s.

 

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
 
 
 */

Solution s = new Solution();
Console.WriteLine(s.LongestPalindrome("babad")); // Output: "bab" or "aba"
Console.WriteLine(s.LongestPalindrome("cbbd"));  // Output: "bb"

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int odd = Expand(s, i, i);
            int even = Expand(s, i, i + 1);

            int length = Math.Max(odd, even);

            if (length > maxLength)
            {
                maxLength = length;
                start = i - (length - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);
    }

    private int Expand(string s, int left, int right)
    {
        while (left >= 0 &&
               right < s.Length &&
               s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}