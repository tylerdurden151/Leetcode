/* 
 * Given two strings ransomNote and magazine, return true 
 * if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 
 */

Solution result = new Solution();
Console.WriteLine(result.CanConstruct("a", "b")); // Output: false
Console.WriteLine(result.CanConstruct("aa", "ab")); // Output: false
Console.WriteLine(result.CanConstruct("aa", "aab")); // Output: true


public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        //handling edge cases
        if (ransomNote == null || magazine == null)
        {
            return false;
        }
        //frequency map
        int[] letterMap = new int[26];
        for (int i = 0; i < ransomNote.Length; i++)
        {
            letterMap[ransomNote[i] - 'a']++;
        }
        for (int j = 0; j < magazine.Length; j++)
        {
            letterMap[magazine[j] - 'a']--;
        }
        foreach (int check in letterMap)
        {
            if (check > 0)
            {
                return false;
            }
        }
        return true;
    }
}