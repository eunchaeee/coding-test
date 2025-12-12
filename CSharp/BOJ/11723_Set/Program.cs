using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    //Solved by bit
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int bit = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string command = parts[0];

            if (command == "add")
            {
                int x = int.Parse(parts[1]);
                bit |= (1 << x);
            }
            else if (command == "remove")
            {
                int x = int.Parse(parts[1]);
                bit &= ~(1 << x);
            }
            else if (command == "check")
            {
                int x = int.Parse(parts[1]);
                string s = ((bit >> x) & 1).ToString();
                sb.AppendLine(s);
            }
            else if (command == "toggle")
            {
                int x = int.Parse(parts[1]);
                bit ^= (1 << x);
            }
            else if (command == "all")
            {
                bit = (1 << 21) - 2;
            }
            else
            {
                bit = 0;
            }
        }
        
        Console.Write(sb.ToString());
    }
    
    
    static void SolvedByHashSet()
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