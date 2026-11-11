/*
 Given an array of characters chars, compress it using the following algorithm:

Begin with an empty string s. For each group of consecutive repeating characters in chars:

If the group's length is 1, append the character to s.
Otherwise, append the character followed by the group's length.
The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

After you are done modifying the input array, return the new length of the array.

You must write an algorithm that uses only constant extra space.

Note: The characters in the array beyond the returned length do not matter and should be ignored.

 

Example 1:

Input: chars = ["a","a","b","b","c","c","c"]
Output: 6
Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
After modifying the input array in-place, the first 6 characters of chars should be ["a","2","b","2","c","3"].
Example 2:

Input: chars = ["a"]
Output: 1
Explanation: The only group is "a", which remains uncompressed since it is a single character.
After modifying the input array in-place, the first character of chars should be ["a"].
Example 3:

Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
Output: 4
Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
After modifying the input array in-place, the first 4 characters of chars should be ["a","b","1","2"].
 */
using System.Text;
//The acutal solution that is accepted by leetcode
public class Solution
{
    public int Compress(char[] chars)
    {
        int read = 0;
        int write = 0;

        while (read < chars.Length)
        {
            char current = chars[read];
            int count = 0;

            // Count consecutive characters
            while (read < chars.Length && chars[read] == current)
            {
                read++;
                count++;
            }

            // Write the character
            chars[write++] = current;

            // Write the count only if greater than 1
            if (count > 1)
            {
                int start = write;

                while (count > 0)
                {
                    chars[write++] = (char)('0' + count % 10);
                    count /= 10;
                }

                Array.Reverse(chars, start, write - start);
            }
        }

        return write;
    }
}



// The way me and Brett did it


public class Solution2
{
    public int Compress(char[] chars)
    {
        // Clarify : 
        // - input doesn't need to be sorted
        // - all lowercase in English letters
        // - return need to be string value
        // - numeric edge cases
        // results example: needs to be abcc = a1b1c2
        // example: aabbcccc => a2b2c4

        // Plan => Potentional solutions
        // loop thru array
        // counter for each duplicate index value
        // HashMap for counts with value
        // stringbuilder for results
        /*   Dictionary<char, int> map = new();
           foreach(char c in chars){
               if(map.ContainsKey(c)){
                   map[c]++;
               }
               else {
                   map[c] = 1;
               }
           }*/

        StringBuilder s = new();
        int left = 0;
        int right = 0;
        int count = 0;
        while (right < chars.Length)
        {
            if (chars[right] == chars[left])
            {
                count++;
                right++;
            }
            else
            {
                s.Append(chars[left]);
                s.Append(count);
                left = right;
                count = 0;
            }
        }
        s.Append(chars[left]);
        s.Append(count);
        Console.WriteLine(s.ToString());
        return s.Length - 1;
    }
}