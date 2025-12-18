class Program
{
    static void Main()
    {
        var parts = Console.ReadLine().Split();
        int n = int.Parse(parts[0]);
        int m = int.Parse(parts[1]);

        var cards = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        
        cards.Sort();

        int maxSum = 0;
        
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    int sum = cards[i] + cards[j] + cards[k];

                    if (sum == m)
                    {
                        Console.WriteLine(sum);
                        return;
                    }


                    if (sum > m)
                        break;
                    
                    if (maxSum < sum) maxSum = sum;
                }
            }
        }
        
        Console.WriteLine(maxSum);
    }
}