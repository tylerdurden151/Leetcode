/*
 Given an integer array nums of unique elements, return all possible subsets (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
Example 2:

Input: nums = [0]
Output: [[],[0]]
 
 */



public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> result = [[]];

        foreach (int num in nums)
        {
            int count = result.Count;

            for (int i = 0; i < count; i++)
            {
                // Create a new List subset by adding the current number to each existing subset
                // meaning copying the existing subset and adding the current number to it
                // example: if the existing subset is [1, 2]
                // and the current number is 3, the new subset will be [1, 2, 3]
                List<int> subset = new(result[i]);  // Copy the existing subset [], [1], [2], [1, 2], ..
                subset.Add(num);  // Add the current number to the new subset
                result.Add(subset); // Add the new subset to the result list
            }
        }

        return result;
    }
}
