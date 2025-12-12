using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        HashSet<int> s = new HashSet<int>();

        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < m; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string command = parts[0];
            
            switch (command)
            {
                case "add":
                    s.Add(int.Parse(parts[1]));
                    break;
                case "remove":
                    s.Remove(int.Parse(parts[1]));
                    break;
                case "check":
                    sb.AppendLine((s.Contains(int.Parse(parts[1]))? "1": "0"));
                    break;
                case "toggle":
                    if (s.Contains(int.Parse(parts[1]))) s.Remove(int.Parse(parts[1]));
                    else s.Add(int.Parse(parts[1]));
                    break;
                case "all":
                    for (int j = 1; j <= 20; j++)
                        s.Add(j);
                    break;
                case "empty":
                    s = new HashSet<int>() { };
                    break;
            }
        }
        
        Console.Write(sb.ToString());
    }
}