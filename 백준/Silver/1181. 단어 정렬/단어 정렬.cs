class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> wordsSet = new HashSet<string>();
        
        for (int i = 0; i < n; i++)
        {
            wordsSet.Add(Console.ReadLine());
        }

        string[] words = new string[wordsSet.Count];
        wordsSet.CopyTo(words);
        
        Array.Sort(words, (a, b) =>
        {
            int x = a.Length.CompareTo(b.Length);
            if (x != 0) return x;
            return a.CompareTo(b);
        });

        for (int i = 0; i < wordsSet.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}