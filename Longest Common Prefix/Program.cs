/*
 Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 
 
 */

string[] strs = { "flower", "flow", "flight" };
string prefix = "flower";

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // Assign the first string as the initial prefix
        string prefix = strs[0];
        // When i = 1, we're comparing "flow" against "flower".
        // Compare the 2nd string with the prefix and shorten the prefix until it matches.
        for (int i = 1; i < strs.Length; i++)
        {
            //StartsWith() is a built-in string method that checks whether a
            //string begins with a specific character or sequence of characters.
            //  true — The string starts with the specified text.
            //  false — The string does not start with the specified text.
            while (!strs[i].StartsWith(prefix))
                // Console.WriteLine(word.StartsWith("flo"));  // true
                // Console.WriteLine(word.StartsWith("flow")); // true
                // Console.WriteLine(word.StartsWith("fly"));  // false
            {
                // Shorten the prefix by removing the last character
                // aka shorten the first string until it matches the prefix.
                prefix = prefix[..^1];
            }
        }

        return prefix;
    
    }
}