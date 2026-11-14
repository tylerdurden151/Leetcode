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
                List<int> subset = new(result[i]);
                subset.Add(num);
                result.Add(subset);
            }
        }

        return result;
    }
}
