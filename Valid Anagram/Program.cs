/*Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false*/
Solution s = new Solution();
Console.WriteLine(s.anaGram("aab", "aba")); // Output: true
Console.WriteLine(s.anaGram("aab", "abb")); // Output: false



public class Solution
{
    //Big O(n) and space O(k) where k is the number of unique characters
    public bool anaGram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (sDict.ContainsKey(c))
            {
                sDict[c]++;
            }
            else
            {
                sDict[c] = 1;
            }
        }
        foreach (char c in t)
        {
            if (!sDict.ContainsKey(c))
            {
                return false;
            }

            sDict[c]--;

            if (sDict[c] < 0)
            {
                return false;
            }
        }
        return true;
    }
    //Fastest Solution!
    //Big O(n) and space O(1) because we are using a fixed size array of 26 for the alphabet
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        int[] arr = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a']++;
            arr[t[i] - 'a']--;
        }

        foreach (int check in arr)
        {
            if (check != 0)
                return false;
        }

        return true;
    }
}