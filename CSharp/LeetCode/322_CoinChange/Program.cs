public class Solution {

    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            foreach (var coin in coins)
            {
                if (i - coin >= 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        
        return dp[amount] > amount ? -1 : dp[amount];
    }
    
    // 이건 어떻게 하는건데...
    // 무조건 큰수를 먼저 채우는 그리디로는 -1 이 그냥 반환되어버릴 수가 있다.ㅠㅠ
    // 뭐가 뭐로 나누어떨어지는지 어케알어...
    
    public int CoinChange2(int[] coins, int amount)
    {
        Array.Sort(coins);
        Array.Reverse(coins);
        int need = amount;
        int idx = 0;
        int count = 0;
        string log = $"{amount} = ";
        while (need > 0)
        {
            if (need >= coins[idx])
            {
                need -= coins[idx];
                count++;
                log += $" + {coins[idx]}";
                Console.WriteLine($"{log} , count = {count}, need = {need}");

            }
            else
            {
                //Console.WriteLine($"{log} , count = {count}");
                idx++;
                if (idx >= coins.Length)
                {
                    return -1;
                }
            }
        }
        
        Console.WriteLine(count);
        return count;
    }

    public static void Main()
    {
        var sol = new Solution();
        //sol.CoinChange([1,2,5], 11);
        //sol.CoinChange([2], 3);
        var result = sol.CoinChange([186,419,83,408], 6249);
        //sol.CoinChange([1], 0);
        Console.WriteLine(result);
    }
}