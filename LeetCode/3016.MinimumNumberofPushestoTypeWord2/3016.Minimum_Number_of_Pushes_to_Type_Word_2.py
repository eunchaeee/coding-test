class Solution:
    def minimumPushes(self, word: str) -> int:
        answer = 0
        count = [0] * 26
        for i in word:
            count[ord(i) - ord('a')] += 1
        count.sort(reverse=True)
        answer = sum(count[0:8]) * 1 + sum(count[8:16]) * 2 + sum(count[16:24]) * 3 + sum(count[24:]) * 4
        return answer



sol = Solution()
print(sol.minimumPushes("merrychristmas"))