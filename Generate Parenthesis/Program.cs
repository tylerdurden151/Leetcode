/*
 * 2. Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

Example 1:

Input: n = 3

Output: ["((()))","(()())","(())()","()(())","()()()"]

Example 2:

Input: n = 1

Output: ["()"]
 */

Solution result = new Solution();
Console.WriteLine(string.Join(", ", result.GenerateParenthesis(3)));
Console.WriteLine(string.Join(", ", result.GenerateParenthesis(1)));


class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        GenerateParenthesis(result, "", 0, 0, n);
        return result;
    }

    private void GenerateParenthesis(IList<string> result, string current, int open, int close, int n)
    {
        if (current.Length == 2 * n)
        {
            result.Add(current);
            return;
        }

        if (open < n)
        {
            GenerateParenthesis(result, current + "(", open + 1, close, n);
        }

        if (close < open)
        {
            GenerateParenthesis(result, current + ")", open, close + 1, n);
        }
    }
}