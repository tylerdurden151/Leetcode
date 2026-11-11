/*
 Given a string word, compress it using the following algorithm:

Begin with an empty string comp. While word is not empty, use the following operation:
Remove a maximum length prefix of word made of a single character c repeating at most 9 times.
Append the length of the prefix followed by c to comp.
Return the string comp.
 
 */

using System.Text;


public class Solution
{
    public string CompressedString(string word)
    {
        StringBuilder comp = new StringBuilder();
        int i = 0;

        while (i < word.Length)
        {
            char current = word[i];
            int count = 0;

            while (i < word.Length &&
                   word[i] == current &&
                   count < 9)
            {
                count++;
                i++;
            }

            comp.Append(count);
            comp.Append(current);
        }

        return comp.ToString();
    }

}