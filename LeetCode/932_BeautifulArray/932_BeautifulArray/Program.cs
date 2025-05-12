public class Solution {
    public int[] BeautifulArray(int n)
    {
        if (n == 1)
            return new int[] { 1 };

        // 재귀적으로 odd와 even 부분 만들기
        // odd : BeautifulArray의 (n+1)/2 인덱스까지의 부분
        var odd = BeautifulArray((n + 1) / 2);
        var even = BeautifulArray(n / 2);
        
        List<int> result = new List<int>();

        // 홀수 위치 채우기 : 기존 값 * 2 - 1 => 항상 홀수
        foreach (var x in odd)
        {
            result.Add(2 * x - 1);
        }

        // 짝수 위치 채우기 : 기존 값 * 2 - 1 => 항상 짝수
        foreach (var x in even)
        {
            result.Add(2 * x);
        }

        return result.ToArray();
    }

    public static void Main()
    {
        var sol = new Solution();
        sol.BeautifulArray(1);
        sol.BeautifulArray(2);
    }
}

