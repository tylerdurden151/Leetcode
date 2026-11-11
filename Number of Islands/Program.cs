/*
 Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
 */


public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int islands = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                // If we find a land cell, we have found a new island
                if (grid[i][j] == '1')
                {
                    // Increment the island count and perform DFS to mark all connected land cells
                    islands++;
                    // Mark the land cell as visited by changing it to '0'
                    DFS(i, j);
                }
            }
        }

        return islands;

        void DFS(int i, int j)
        {
            // i < 0 Means we move above the grid
            // j < 0 Means we move left of the grid
            // i >= grid.Length Means we move below the grid
            // j >= grid[0].Length Means we move right of the grid
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0')
            {
                return;
            }

            // Mark the cell as visited by changing it to '0'
            grid[i][j] = '0';

            DFS(i + 1, j); // Down
            DFS(i - 1, j); // Up
            DFS(i, j + 1); // Right
            DFS(i, j - 1); // Left
        }
    }
}



public class Solution2
{
    public int NumIslands(char[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        // Search through every cell
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1')
                {
                    islands++;
                    DFS(grid, r, c);
                }
            }
        }

        return islands;
    }

    private void DFS(char[][] grid, int r, int c)
    {
        // Stop if outside the grid
        if (r < 0 || r >= grid.Length ||
            c < 0 || c >= grid[0].Length)
        {
            return;
        }

        // Stop if the cell is water or already visited
        if (grid[r][c] == '0')
        {
            return;
        }

        // Mark this land as visited
        grid[r][c] = '0';

        // Explore all four neighbors
        DFS(grid, r - 1, c); // Up
        DFS(grid, r + 1, c); // Down
        DFS(grid, r, c - 1); // Left
        DFS(grid, r, c + 1); // Right
    }
}

