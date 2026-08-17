/*You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. 
 * If a string is longer than the other, append the additional letters onto the end of the merged string.
Return the merged string.

Example 1:
Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1: a b c
word2: p q r
merged: a p b q c r

Example 2:
Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1: a b
word2: p q r s
merged: a p b q r s
*/

using System.Text;

Solution s = new Solution();
string word1 = "abc";
string word2 = "pqr";
Console.WriteLine(s.MergeAlternately(word1, word2));


public class Solution
{
    //Simple and cleaner solution using StringBuilder
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder result = new StringBuilder();
        int i = 0;

        while (i < word1.Length || i < word2.Length)
        {
            if (i < word1.Length) result.Append(word1[i]);
            if (i < word2.Length) result.Append(word2[i]);
            i++;
        }

        return result.ToString();

    }

    public string MergeAlternately2(string word1, string word2)
    {
        //strings are immutable
        char[] result = new char[word1.Length + word2.Length];
        int word1pos = 0;
        int word2pos = 0;
        int pos = 0;

        while (word1pos < word1.Length || word2pos < word2.Length)
        {
            if (word1pos < word1.Length)
            {
                result[pos++] = word1[word1pos++];
            }
            if (word2pos < word2.Length)
            {
                result[pos++] = word2[word2pos++];
            }

        }
        return new string(result);
    }
}