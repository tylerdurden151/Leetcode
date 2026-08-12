/*
 * You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
DO NOT allocate another 2D matrix and do the rotation.

example 1:Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]

Example 2: Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
 */
using System;
using System.Linq;

Solution s = new Solution();



int[][] matrix1 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
s.PrintMatrix(matrix1);
Console.WriteLine();
s.Rotate(matrix1);
s.PrintMatrix(matrix1);


Console.WriteLine();
int[][] matrix2 = new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } };
s.PrintMatrix(matrix2);
Console.WriteLine();
s.Rotate(matrix2);
s.PrintMatrix(matrix2);


public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                swap_diag(matrix, i, j);
            }
        }
        for (int row = 0; row < n; row++)
        {
            //Delcare two pointers, one at the start and one at the end of the row
            int start = 0;
            int end = n - 1;
            while (start < end)
            {
                //Swap the elements at the start and end pointers
                int temp = matrix[row][start];
                matrix[row][start] = matrix[row][end];
                matrix[row][end] = temp;
                //Move the pointers towards the center
                start++;
                end--;
            }
        }
    }

    //Helper method
    //Swap the elements at the given indices in the matrix
    private void swap_diag(int[][] matrix, int i, int j)
    {
        int temp = matrix[i][j];
        matrix[i][j] = matrix[j][i];
        matrix[j][i] = temp;
    }

    public void PrintMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}