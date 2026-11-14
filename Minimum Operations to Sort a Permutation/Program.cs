/*
 You are given an integer array nums of length n, where nums is a permutation of the integers from 0 to n - 1.

You may perform only the following operations:

Reverse the entire array.
Rotate Left by One: Move the first element to the end of the array, and rest elements to left by one position.
Return an integer denoting the minimum number of operations required to sort the array in increasing order. 
If it is not possible to sort the array using only the given operations, return -1.
 */


public class Solution
{
    public int MinOperations(int[] nums)
    {
        int n = nums.Length;
        int zero = Array.IndexOf(nums, 0);

        bool forward = true;
        bool backward = true;

        for (int i = 0; i < n; i++)
        {
            if (nums[(zero + i) % n] != i)
                forward = false;

            if (nums[(zero - i + n) % n] != i)
                backward = false;
        }

        if (forward)
            return Math.Min(zero, n - zero + 2);

        if (backward)
            return Math.Min(zero + 2, n - zero);

        return -1;
    }
}
