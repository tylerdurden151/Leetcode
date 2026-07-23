/*
4. You are given a string s consisting only of uppercase English letters.

You can apply some operations to this string where, in one operation, you can remove 
any occurrence of one of the substrings "AB" or "CD" from s.
Return the minimum possible length of the resulting string that you can obtain.
Note that the string concatenates after removing the substring and
could produce new "AB" or "CD" substrings.

**Hint : Use Replace method of string.

Example 1:

Input: s = "ABFCACDB"

Output: 2

Explanation: We can do the following operations:

- Remove the substring "ABFCACDB", so s = "FCACDB".

- Remove the substring "FCACDB", so s = "FCAB".

- Remove the substring "FCAB", so s = "FC".

So the resulting length of the string is 2.

It can be shown that it is the minimum length that we can obtain.

Example 2:

Input: s = "ACBBD"

Output: 5

Explanation: We cannot do any operations on the string so the length remains the same.

*/

Solution solution = new Solution("ABFCACDB");
Console.WriteLine(solution.MinLength());


public class Solution
{
    private string _s = string.Empty;
    public string S { get { return _s; } set { _s = value; } }
    public Solution(string s)
    {
        S = s;
    }
    public int MinLength()
    {
        // Keep replacing "AB" and "CD" until no more replacements can be made
        while (S.Contains("AB") || S.Contains("CD"))
        {
            S = S.Replace("AB", "").Replace("CD", "");
        }
        return S.Length;
    }
}