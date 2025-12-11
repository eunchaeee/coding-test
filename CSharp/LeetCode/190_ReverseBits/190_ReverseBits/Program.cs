public class Solution {
    public int ReverseBits(int n)
    {
        int answer = 0;
        for (int i = 0; i < 32; i++)
        {
            answer += ((n >> i) & 1) * (int)MathF.Pow(2, 31 - i);
        }

        return answer;
    }
    
    public int ReverseBits2(int n)
    {
        int answer = 0;
        for (int i = 0; i < 32; i++)
        {
            answer <<= 1;  // answer를 왼쪽으로 밀어 뒤에 공간을 만든다.
            answer |= (n & 1);  // n의 마지막 비트를 answer의 마지막 자리에 붙인다.
            n >>= 1;  // n을 오른쪽으로 밀어서 다음 비트를 준비한다.
        }

        return answer;
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.ReverseBits(2147483644));
    }
}