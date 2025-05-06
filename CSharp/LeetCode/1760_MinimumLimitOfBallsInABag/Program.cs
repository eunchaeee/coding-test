public class Solution {
    public int MinimumSize(int[] nums, int maxOperations)
    {
        int left = 1;
        int right = nums.Max();  // 가능한 최대값 = 가장 큰 가방 크기

        while (left < right)
        {
            int penalty = (left + right) / 2;

            int operations = 0;
            foreach (int num in nums)
            {
                // 올림을 내림으로 바꾸는 트릭
                // 원래는 ((float)num / p) 을 올림한 값에서 - 1
                // 이걸 (num + (p - 1)) / p  의 내림 값에서 -1 한걸로 변형
                // (num - 1) / p 에 + 1 에 - 1을 한 값이 됨.
                // 정리하면 (num - 1) / p
                operations += (num - 1) / penalty;  // 이 가방을 mid 이하로 분할하는데 필요한 횟수 
            }

            if (operations > maxOperations)
            {
                // 연산 횟수가 너무 많음 -> penalty 키우기
                left = penalty + 1;
            }
            else
            {
                // 가능한 경우 -> 더 작은 penalty로 시도
                right = penalty;
            }
        }
        return left;
    }

    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.MinimumSize([9], 2));
        Console.WriteLine(sol.MinimumSize([2, 4, 8, 2], 4));
    }
}