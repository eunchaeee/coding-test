class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] time = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        
        Array.Sort(time);

        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            answer += time[i] * (n - i);
        }
        
        Console.WriteLine(answer);
    }
}