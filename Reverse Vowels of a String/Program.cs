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

Solution s = new Solution();
Console.WriteLine(s.ReverseVowels("IceCreAm")); // Output: "AceCreIm"
Console.WriteLine(s.ReverseVowels("leetcode")); // Output: "leotcede"

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

// Fastest solution using two pointers and
// a helper function to check for vowels
public class Solution2
{
    public string ReverseVowels(string s)
    {
        var chars = s.ToCharArray();
        var len = chars.Length;

        int l = 0;
        int r = len - 1;
        while (l < r)
        {
            if (!IsVowel(chars[l]))
            {
                l++;
            }
            else if (!IsVowel(chars[r]))
            {
                r--;
            }
            else
            {
                (chars[l], chars[r]) = (chars[r], chars[l]);
                l++; r--;
            }
        }

        return new string(chars);
    }

    private bool IsVowel(char c)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
         || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            return true;
        }
        return false;
    }
}

// Another solution using two pointers and string.Contains() to check for vowels
//Easier to read but slower than the previous solution
public class Solution3
{
    public string ReverseVowels(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        string vowels = "aeiouAEIOU";
        char[] sChar = s.ToCharArray();
        char temp;
        while (left < right)
        {

            while (left < right && !vowels.Contains(sChar[left]))
            {
                left++;
            }

            while (left < right && !vowels.Contains(sChar[right]))
            {
                right--;
            }
            if (left < right)
            {
                temp = sChar[left];
                sChar[left] = sChar[right];
                sChar[right] = temp;
                left++;
                right--;
            }
        }
        return new string(sChar);
    }
}