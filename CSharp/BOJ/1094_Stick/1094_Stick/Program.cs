class Solution
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int count = 0;
        
        while (x != 0)
        {
            x &= (x - 1);
            count++;
        }
        Console.WriteLine(count);
    }
}