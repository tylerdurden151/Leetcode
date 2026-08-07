/*
 Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"
 
 */


public class Solution
{
    public string ReverseVowels(string s)
    {
        // Strings cannot be modified, so convert to char[]
        char[] reversed = s.ToCharArray();

        int left = 0;
        int right = s.Length - 1;

        List<char> vowels = new List<char>()
        {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };

        while (left < right)
        {
            // Move left until we find a vowel
            while (left < right && !vowels.Contains(reversed[left]))
            {
                left++;
            }

            // Move right until we find a vowel
            while (left < right && !vowels.Contains(reversed[right]))
            {
                right--;
            }

            // Swap the two vowels
            char temp = reversed[left];
            reversed[left] = reversed[right];
            reversed[right] = temp;

            left++;
            right--;
        }

        return new string(reversed);
    }
}