public class Solution
{
    public int NumTilePossibilities(string tiles)
    {
        HashSet<string> comb = new HashSet<string>();
        List<int> path = new List<int>();
        bool[] visited = new bool[tiles.Length];
        
        DFS(tiles, path, visited, comb);
        return comb.Count;
    }

    public void DFS(string tiles, List<int> path, bool[] visited, HashSet<string> comb)
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (visited[i]) continue;

            visited[i] = true;
            path.Add(tiles[i]);
            comb.Add(string.Join("", path));
            
            DFS(tiles, path, visited, comb);

            visited[i] = false;
            path.RemoveAt(path.Count - 1);
        }
    }

    public static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.NumTilePossibilities("AAB"));
        Console.WriteLine(sol.NumTilePossibilities("AAABBC"));
        Console.WriteLine(sol.NumTilePossibilities("V"));
    }
}