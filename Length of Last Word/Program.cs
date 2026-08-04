/*
* Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.
Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
*/
Solution s = new Solution();
Console.WriteLine(s.Word("Hello World")); // Output: 5")
Console.WriteLine(s.Word("   fly me   to   the moon  ")); // Output: 4")
Console.WriteLine(s.Word("luffy is still joyboy")); // Output: 6")

Solution2 s2 = new Solution2();
Console.WriteLine(s2.LengthOfLastWord("Hello World")); // Output: 5")
Console.WriteLine(s2.LengthOfLastWord("   fly me   to   the moon  ")); // Output: 4")
Console.WriteLine(s2.LengthOfLastWord("luffy is still joyboy")); // Output: 6")

public class Solution
{
    public int Word(string s)
    {

        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string lastWord = words[words.Length - 1];
        return lastWord.Length;


    }
}

// This solution is more efficient than the first one because it doesn't create an array of words,
// it just iterates through the string once and counts the length of the last word.
public class Solution2
{
    public int LengthOfLastWord(string s)
    {

        int i = s.Length - 1;

        while (i >= 0 && s[i] == ' ')
        {
            i--;
        }

        int end = i;

        while (i >= 0 && s[i] != ' ')
        {
            i--;
        }

        return (end - i);

    }
}