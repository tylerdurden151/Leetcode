/*
 Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]
 

Constraints:

1 <= numRows <= 30
 */

Solution s = new Solution();
var result = s.Generate(5);
Console.WriteLine(string.Join(", ", result.Select(r => "[" + string.Join(",", r) + "]")));

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows < 1 || numRows > 30)
        {
            throw new ArgumentException("numRows must be between 1 and 30");
        }       
        //declare result list
        List<IList<int>> result = new List<IList<int>>(numRows);

        // loop thru the number of rows
        for (int i = 0; i < numRows; i++)
        {
            List<int> row = new List<int>();
            row.Add(1);
            for (int j = 1; j < i; j++)
            {
                row.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }
            if (i > 0)
            {
                row.Add(1);
            }
            result.Add(row);

        }
        return result;
    }
}