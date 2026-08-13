


using System;
Solution s = new Solution();
int result1 = s.RemoveDuplicates(new int[] { 1, 2, 3, 4, 5 });
int result2 = s.RemoveDuplicates(new int[] { 1, 2, 3, 1 });
int result3 = s.RemoveDuplicates(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);


//Same setup as Contains Duplicates
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int count = 0;
        int[] result = new int[nums.Length];
        HashSet<int> seen = new HashSet<int>();

        foreach (int value in nums)
        {
            if (seen.Add(value))
            {
                nums[count] = value;
                count++;
            }
        }

        return count;
    }

    //Faster Solution O(1) space complexity
    public class Solution2
    {
        public int RemoveDuplicates(int[] nums)
        {
            int current = 1;
            int uniqueIndex = 0;

            while (current < nums.Length)
            {
                if (nums[current] != nums[uniqueIndex])
                {
                    uniqueIndex++;
                    nums[uniqueIndex] = nums[current];
                }

                current++;
            }

            return uniqueIndex + 1;
        }
    }
