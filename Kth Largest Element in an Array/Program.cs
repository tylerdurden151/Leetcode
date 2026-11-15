/*
Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

 

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
 */

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // Min -heap to keep track of the k largest elements
        PriorityQueue<int, int> heap = new();

        foreach (int num in nums)
        {
            heap.Enqueue(num, num);

            if (heap.Count > k)
                heap.Dequeue();
        }

        return heap.Peek();
    }
}