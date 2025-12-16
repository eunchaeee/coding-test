class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] serials = new string[n];

        for (int i = 0; i < n; i++)
        {
            serials[i] = Console.ReadLine();
        }
        

        Array.Sort(serials, (a, b) => 
        {
            int result1 = a.Length.CompareTo(b.Length);
            if (result1 != 0) return result1;
            int sumA = 0;
            int sumB = 0;

            foreach (char c in a)
            {
                if (char.IsDigit(c))
                {
                    sumA += (c - '0');
                }
            }

            foreach (var c in b)
            {
                if (char.IsDigit(c))
                {
                    sumB += (c - '0');
                }
            }

            int result2 = sumA.CompareTo(sumB);
            if (result2 != 0) return result2;

            return a.CompareTo(b);
        });

        foreach (var s in serials)
        {
            Console.WriteLine(s);
        }
    }
}