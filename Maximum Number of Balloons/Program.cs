/*Question 2:

Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

You can use each character in text at most once. Return the maximum number of instances that can be formed.
Example 1:

Input: text = "nlaebolko"

Output: 1

Example 2:
Input: text = "loonbalxballpoon"

Output: 2

Example 3:

Input: text = "leetcode"

Output: 0
 
 */
Solution result = new Solution();
Console.WriteLine("Enter a string to form the word 'balloon':");
string input = "loonbalxballpoon";
int maxBalloons = result.MaxNumberOfBalloons(input);
Console.WriteLine($"Maximum number of 'balloon' instances: {maxBalloons}");

public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        int[] freq = new int[26];

        foreach (char c in text)
        {
            freq[c - 'a']++;
        }

        int b = freq['b' - 'a'];
        int a = freq['a' - 'a'];
        int l = freq['l' - 'a'] / 2;
        int o = freq['o' - 'a'] / 2;
        int n = freq['n' - 'a'];

        return Math.Min(
            Math.Min(b, a),
            Math.Min(Math.Min(l, o), n)
        );
    }
}