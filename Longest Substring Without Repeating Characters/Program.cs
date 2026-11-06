/*
 Given a string s, find the length of the longest substring without duplicate characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
 */

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        // frequency map / sliding window
        HashSet<char> seen = new HashSet<char>();

        int left = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // If current character is already in the window,
            // shrink the window from the left
            while (seen.Contains(s[i]))
            {
                seen.Remove(s[left]);
                left++;
            }

            // Add current character
            seen.Add(s[i]);

            // Current window length
            int length = i - left + 1;

            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        return maxLength;
    }
}