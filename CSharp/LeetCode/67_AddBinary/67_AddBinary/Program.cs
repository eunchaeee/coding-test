using System.Text;

public class Solution {
    public static string AddBinary(string a, string b)
    {
        int lastA = a.Length - 1;
        int lastB = b.Length - 1;

        int cnt = 0;
        int carry = 0;

        bool addA = true;
        bool addB = true;
        
        var sb = new StringBuilder();
        
        while (addA || addB)
        {
            if (addA)
            {
                carry += a[lastA - cnt] - '0';
            }
            
            if (addB)
            {
                carry += b[lastB - cnt] - '0';
            }

            if (carry == 0)
            {
                sb.Append("0");
                carry = 0;
            }
            else if (carry == 1)
            {
                sb.Append("1");
                carry = 0;
            }
            else if (carry == 2)
            {
                sb.Append("0");
                carry = 1;
            }
            else if (carry == 3)
            {
                sb.Append("1");
                carry = 1;
            }
            
            cnt++;

            if (lastA - cnt < 0) addA = false;
            if (lastB - cnt < 0) addB = false;
        }
        
        if (carry  != 0)
            sb.Append(carry);
        
        var chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static string AddBinary2(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        var sb = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';

            sb.Append(sum % 2);
            carry = sum / 2;
        }

        var chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    
    static void Main()
    {
        Console.WriteLine(AddBinary("11", "1"));
        Console.WriteLine(AddBinary("1010", "1011"));
        Console.WriteLine(AddBinary2("11", "1"));
        Console.WriteLine(AddBinary2("1010", "1011"));
    }
}