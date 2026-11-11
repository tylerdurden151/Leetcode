/*
 Given a 2D grid consists of 0s (land) and 1s (water).  
An island is a maximal 4-directionally connected group of 0s and a closed island is an island totally 
(all left, top, right, bottom) surrounded by 1s.

Return the number of closed islands.
Input: grid = [
[1,1,1,1,1,1,1,0],
[1,0,0,0,0,1,1,0],
[1,0,1,0,1,1,1,0],
[1,0,0,0,0,1,0,1],
[1,1,1,1,1,1,1,0]
]

Output: 2

Explanation:

The grid contains four islands of 0s.
The island spanning rows 1 to 3 and columns 1 to 4 is surrounded entirely by 1s. It also encloses the water cell at row 2, column 2. It is therefore closed.
The single 0 at row 3, column 6 has 1s on all four sides, so it is also closed.
The two remaining islands both lie in column 7, which is on the border of the grid, so neither of them is closed.
Two islands are closed, shown in gray, so the answer is 2.
 */

public class Solution
{
    public int ClosedIsland(int[][] grid)
    {
        // remove all islands touching the border
        // Search the grid
        // Count the remaining islands '0'
        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;

        // Step 1: Remove islands touching edges
        for (int i = 0; i < rows; i++)
        {
            Dfs(i, 0);
            Dfs(i, cols - 1);
        }

        for (int j = 0; j < cols; j++)
        {
            Dfs(0, j);
            Dfs(rows - 1, j);
        }

        // Step 2: Count remaining islands
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < cols - 1; j++)
            {
                if (grid[i][j] == 0)
                {
                    count++;
                    Dfs(i, j);
                }
            }
        }

        return count;

        void Dfs(int i, int j)
        {
            // Stop if outside the grid or on water
            if (i < 0 || i >= rows ||
                j < 0 || j >= cols ||
                grid[i][j] == 1)
                return;

            // Turn visited land into water
            grid[i][j] = 1;

            // Check all four directions
            Dfs(i + 1, j); // Down
            Dfs(i - 1, j); // Up
            Dfs(i, j + 1); // Right
            Dfs(i, j - 1); // Left
        }
    }
}