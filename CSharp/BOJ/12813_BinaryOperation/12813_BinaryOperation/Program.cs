using System.Text;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        int n = a.Length;
        
        StringBuilder op1 = new StringBuilder(n);
        StringBuilder op2 = new StringBuilder(n);
        StringBuilder op3 = new StringBuilder(n);
        StringBuilder op4 = new StringBuilder(n);
        StringBuilder op5 = new StringBuilder(n);

        for (int i = 0; i < n; i++)
        {
            int bitA = a[i] - '0';
            int bitB = b[i] - '0';

            op1.Append(bitA & bitB);
            op2.Append(bitA | bitB);
            op3.Append(bitA ^ bitB);
            op4.Append(1 - bitA);
            op5.Append(1 - bitB);
        }
        
        Console.WriteLine(op1);
        Console.WriteLine(op2);
        Console.WriteLine(op3);
        Console.WriteLine(op4);
        Console.WriteLine(op5);
    }
}