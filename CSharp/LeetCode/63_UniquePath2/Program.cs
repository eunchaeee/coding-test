public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        
        int[][] paths = new int[m][];

        for (int i = 0; i < m; i++)
        {
            paths[i] = new int[n];
        }

        paths[0][0] = 1;
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1)
                {
                    paths[i][j] = 0;
                    continue;
                }
                
                if (i > 0)
                {
                    paths[i][j] += paths[i - 1][j];
                }
                if (j > 0)
                {
                    paths[i][j] += paths[i][j - 1];
                }
                //Console.WriteLine($"paths[{i}][{i}] = {paths[i][j]}");
            }
        }

        return paths[m-1][n-1];
    }

    //....dfs인줄알고 자신있게 풀었는데 dp였어.....흑흑흑
    public int UniquePathsWithObstaclesDFS(int[][] obstacleGrid)
    {
        int answer = 0;
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        if (obstacleGrid[0][0] == 1) return answer;
        
        dfs(obstacleGrid, 0, 0, m, n, ref answer);
        return answer;
    }

    public void dfs(int[][] obstacleGrid, int x, int y, int m, int n, ref int answer)
    {
        if (x == m - 1 && y == n- 1 && obstacleGrid[x][y] == 0)
        {
            answer++;
            return;
        }

        if (x + 1 < m && obstacleGrid[x+1][y] == 0)
        {
            dfs(obstacleGrid, x + 1, y, m, n, ref answer);
        }

        if (y + 1 < n && obstacleGrid[x][y+1] == 0)
        {
            dfs(obstacleGrid, x, y + 1, m, n, ref answer);
        }
    }
    
    public static void Main()
    {
        Solution sol = new Solution();
        int result = sol.UniquePathsWithObstacles([[0, 0, 0], [0, 1, 0], [0, 0, 0]]);
        int result2 = sol.UniquePathsWithObstacles([[1]]);
        int result3 = sol.UniquePathsWithObstacles([[1, 0]]);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}