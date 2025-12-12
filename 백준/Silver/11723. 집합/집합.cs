using System.Text;

class Program
{
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
}