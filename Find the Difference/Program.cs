/**/

Solution result = new Solution();
Console.WriteLine(result.FindTheDifference("abcd", "abcde"));

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        //handle edge cases
        //frequency map
        int[] letterMap = new int[26];
        // Count letters from s
        for (int i = 0; i < s.Length; i++)
        {
            letterMap[s[i] - 'a']++;
        }

        // Remove letters found in t
        for (int n = 0; n < t.Length; n++)
        {
            letterMap[t[n] - 'a']--;
        }

        for (int j = 0; j < letterMap.Length; j++)
        {
            if (letterMap[j] != 0)
            {
                return (char)('a' + j);
            }
        }
        return '\0';
    }
}