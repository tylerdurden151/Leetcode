/*
 Given an array of strings words, return the first
palindromic string in the array. If there is no such string, return an empty string "".

A string is palindromic if it reads the same forward and backward.

 

Example 1:

Input: words = ["abc","car","ada","racecar","cool"]
Output: "ada"
Explanation: The first string that is palindromic is "ada".
Note that "racecar" is also palindromic, but it is not the first.
Example 2:

Input: words = ["notapalindrome","racecar"]
Output: "racecar"
Explanation: The first and only string that is palindromic is "racecar".
Example 3:

Input: words = ["def","ghi"]
Output: ""
Explanation: There are no palindromic strings, so the empty string is returned.
 
 */
Solution s = new Solution();
Console.WriteLine(s.FirstPalindrome(new string[] { "abc", "car", "ada", "racecar", "cool" })); // Output: "ada"
Console.WriteLine(s.FirstPalindrome(new string[] { "notapalindrome", "racecar" })); // Output: "racecar"
Console.WriteLine(s.FirstPalindrome(new string[] { "def", "ghi" })); // Output: ""

public class Solution
{

    public string FirstPalindrome(string[] words)
    {
        foreach (string n in words)
        {
            int left = 0;
            int right = n.Length - 1;
            bool palindrome = true;

            while (left < right)
            {
                if (n[left] != n[right])
                {
                    palindrome = false;
                    break;
                }

                left++;
                right--;
            }

            if (palindrome)
            {
                return n;
            }
        }

        return "";
    }
}