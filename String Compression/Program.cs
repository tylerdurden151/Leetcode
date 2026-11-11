/*
 
 */

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
using System.Text;

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