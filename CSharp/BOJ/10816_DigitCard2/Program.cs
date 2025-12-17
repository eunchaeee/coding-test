using System.Text;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int n = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split();

 
        foreach (var num in nums)
        {
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }
        

        StringBuilder sb = new StringBuilder();
        int m = int.Parse(Console.ReadLine());
        var inputs = Console.ReadLine().Split();
        
        foreach (var input in inputs)
        {
            dict.TryGetValue(input, out int value);
            sb.Append(value);
            sb.Append(" ");
        }
        
        Console.Write(sb.ToString());
    }
}