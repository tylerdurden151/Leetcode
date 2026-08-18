/*
 Given an array of integers nums, sort the array in ascending order and return it.

You must solve the problem without using any built-in functions in O(nlog(n)) time complexity and with the smallest space complexity possible.

 

Example 1:

Input: nums = [5,2,3,1]
Output: [1,2,3,5]
Explanation: After sorting the array, the positions of some numbers are not changed (for example, 2 and 3), 
while the positions of other numbers are changed (for example, 1 and 5).
 
 */

Solution s = new Solution();
int[] result1 = s.SortArray(new int[] { 88, 90, 77, 100 });
int[] result2 = s.SortArray2(new int[] { 88, 90, 77, 100 });
Console.WriteLine(string.Join(", ", result1));
Console.WriteLine(string2.Join(", ", result2));

public class Solution
{
    //Big O(n log(n))
    //Mergesort (fastest for this problem)
    public int[] SortArray(int[] nums)
    {
        int[] temp = new int[nums.Length];

        void MergeSort(int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(left, mid);
            MergeSort(mid + 1, right);
            Merge(left, mid, right);
        }

        void Merge(int left, int mid, int right)
        {
            int i = left, j = mid + 1, k = left;

            while (i <= mid && j <= right)
            {
                if (nums[i] <= nums[j])
                    temp[k++] = nums[i++];
                else
                    temp[k++] = nums[j++];
            }
            while (i <= mid) temp[k++] = nums[i++];
            while (j <= right) temp[k++] = nums[j++];

            for (int x = left; x <= right; x++)
                nums[x] = temp[x];
        }

        MergeSort(0, nums.Length - 1);
        return nums;
    }

    //Big O(n log(n))
    //Quick sort
    public int[] SortArray2(int[] nums)
    {
        void QuickSort(int head, int tail)
        {
        if (head >= tail)
        {
            return;
        }

            int l = head;
            int r = tail;
            int m = (r - l) / 2 + l;
            int pivot = nums[m];

            while (r >= l)
            {
            while (r >= l && nums[l] < pivot)
            {
                l++;
            }
            while (r >= l && nums[r] > pivot) { 
                r--; 
            }


                if (r >= l)
                {
                    (nums[l], nums[r]) = (nums[r], nums[l]);
                    l++;
                    r--;
                }
            }

            QuickSort(head, r);
            QuickSort(l, tail);
        }

        QuickSort(0, nums.Length - 1);
        return nums;
    }


    //WRONG! Big O(n^2) and not Big O(n log(n))
    //This is Selection Sort
    public int[] SortArray3(int[] nums)
    {
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int max = i;
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[j] < nums[max])
                    {
                        max = j;
                    }
                }

                (nums[max], nums[i]) = (nums[i], nums[max]);

            }
            return nums;

        }
    }

    public int[] SortArray4(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums;
        }

        int[] buf = (int[])nums.Clone();
        MergeSort(buf, nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] src, int[] dst, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int mid = left + (right - left) / 2;

        // note the swap: children write into src
        MergeSort(dst, src, left, mid);
        MergeSort(dst, src, mid + 1, right);

        int i = left, j = mid + 1;
        for (int k = left; k <= right; k++)
        {
            if (j > right || (i <= mid && src[i] <= src[j]))
            {
                dst[k] = src[i++];
            }
            else
            {
                dst[k] = src[j++];
            }
        }
    }


}