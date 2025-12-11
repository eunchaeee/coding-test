class Solution
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long answer = 0;
        
        long pow = 1;
        while (n > 0)
        {
            if ((n & 1L) == 1L)
            {
                answer += pow;
            }

            pow *= 3;
            n >>= 1;
        }
        
        Console.WriteLine(answer);
    }
}