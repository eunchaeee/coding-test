/*
 * 1부터 시작해서
 * 하나를 고르고
 * 그 다음 숫자부터 다시 고르고
 * k개가 되면 저장하고
 * 다시 돌아와서 다른 선택을 해본다.
 */

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var result = new List<IList<int>>();
        var path = new List<int>(k);
        DFS(1, n, k, path, result);
        return result;
    }

    void DFS(int start, int n, int k, List<int> path, List<IList<int>> result)
    {
        // 종료 조건
        if (path.Count == k)
        {
            result.Add(new List<int>(path));
            return;
        }
        
        // 다음 숫자 선택
        for (int i = start; i <= n; i++)
        {
            path.Add(i);
            DFS(i + 1, n, k, path, result);
            path.RemoveAt(path.Count - 1);  
        }
    }

    public static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.Combine(4, 2));
    }
}