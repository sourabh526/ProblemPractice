using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class RecursionBacktrackingProblem
    {
        int count;
        public int UniquePathsIII(List<List<int>> grid)
        {
            int startX = 0;
            int startY = 0;
            int countZeros = 1;
            count = 0;

            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[0].Count; j++)
                {
                    if (grid[i][j] == 0) countZeros++;
                    else if (grid[i][j] == 1) { startX = i; startY = j; }
                }
            }

            UniquePathsIIIUtil(grid, startX, startY, countZeros);

            return count;
        }

        private void UniquePathsIIIUtil(List<List<int>> grid, int row, int col, int countZeros)
        {
            if (row < 0 || col < 0 ||
               row >= grid.Count ||
               col >= grid[0].Count ||
               countZeros < 0 || grid[row][col] == -1)
                return;

            if (grid[row][col] == 2)
            {
                if (countZeros == 0) count++;
                return;
            }

            grid[row][col] = -1;

            UniquePathsIIIUtil(grid, row + 1, col, countZeros - 1);
            UniquePathsIIIUtil(grid, row, col + 1, countZeros - 1);
            UniquePathsIIIUtil(grid, row - 1, col, countZeros - 1);
            UniquePathsIIIUtil(grid, row, col - 1, countZeros - 1);

            grid[row][col] = 0;
        }
    }
}
