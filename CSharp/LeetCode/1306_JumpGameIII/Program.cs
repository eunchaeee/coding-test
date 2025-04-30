using System;

public class Solution {
    public bool CanReach(int[] arr, int start)
    {
        bool[] visited = new bool[arr.Length];
        visited[start] = true;
        return DFS(start, arr, visited);
    }

    public bool DFS(int now, int[] arr, bool[] visited)
    {
        int left = now - arr[now];
        int right = now + arr[now];
        
        if (arr[now] == 0) return true;

        if (left >= 0 && left < arr.Length && visited[left] == false)
        {
            visited[left] = true;
            if (DFS(left, arr, visited)) return true;
        }

        if (right >= 0 && right < arr.Length && visited[right] == false)
        {
            visited[right] = true;
            if (DFS(right, arr, visited)) return true;
        }
        return false;
    }
}

public class SolutionGPT
{
    public bool CanReach(int[] arr, int start)
    {
        return DFS(start, arr, new bool[arr.Length]);
    }

    private bool DFS(int now, int[] arr, bool[] visited)
    {
        if (now < 0 || now >= arr.Length || visited[now]) return false;
        if (arr[now] == 0) return true;

        visited[now] = true;
        return DFS(now + arr[now], arr, visited) || DFS(now - arr[now], arr, visited);
    }
}

class Program {
    static void Main(string[] args) {
        var sol = new Solution();
        Console.WriteLine(sol.CanReach([4,2,3,0,3,1,2], 5));  // 예상 결과: true
        Console.WriteLine(sol.CanReach([4,2,3,0,3,1,2], 0));  // 예상 결과: true
        Console.WriteLine(sol.CanReach([3,0,2,1,2], 2));  // 예상 결과: false
    }
}