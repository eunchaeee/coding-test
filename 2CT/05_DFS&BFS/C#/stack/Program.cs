using System.Collections.Generic;

public class Solution
{
    public void solution()
    {
        // Stack : Push() / Pop()
        Stack<int> s = new Stack<int>();
        s.Push(1);
        s.Push(2);
        s.Pop();

        List<int> l = new List<int>();
        l.Add(1);
        l.Add(2);
        l.Add(3);
        l.RemoveAt(l.Count - 1);
        l.RemoveAt(l.Count - 1);
        Console.WriteLine(l);
    }

    public static void Main()
    {
        Solution sol = new Solution();
        sol.solution();
    }
}
