


using System;
Solution s = new Solution();
int result1 = s.RemoveDuplicates(new int[] { 1, 2, 3, 4, 5 });
int result2 = s.RemoveDuplicates(new int[] { 1, 2, 3, 1 });
int result3 = s.RemoveDuplicates(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
Console.WriteLine($"Result 1: {result1}");
Console.WriteLine($"Result 2: {result2}");
Console.WriteLine($"Result 3: {result3}");
Console.WriteLine();
Solution2 s2 = new Solution2();
int result4 = s2.RemoveDuplicates(new int[] { 1, 2, 3, 4, 5 });
int result5 = s2.RemoveDuplicates(new int[] { 1, 2, 3, 1 });
int result6 = s2.RemoveDuplicates(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
Console.WriteLine($"Result 4: {result4}");
Console.WriteLine($"Result 5: {result5}");
Console.WriteLine($"Result 6: {result6}");


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
}

    //Faster Solution O(1) space complexity
    public class Solution2
    {
    public int RemoveDuplicates(int[] nums)
    {
        int read = 1;
        int write = 0;

        while (read < nums.Length)
        {
            if (nums[read] != nums[write])
            {
                write++;
                nums[write] = nums[read];
            }

            read++;
        }

        return write + 1;
    }
}
