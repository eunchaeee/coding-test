from typing import List

# 아이디어
# 보트 남은 무게(limit) 안에서 항상 가장 무거운 사람을 먼저 고른다.

class Solution:
    def numRescueBoats(self, people: List[int], limit: int) -> int:
        people.sort()
        i = 0
        j = len(people) - 1
        count = 0

        while i <= j:
            if people[i] + people[j] <= limit:
                i += 1
            j -= 1
            count += 1
        return count

sol = Solution()
print(sol.numRescueBoats([1, 2], 3))
print(sol.numRescueBoats([3, 2, 2, 1], 3))
print(sol.numRescueBoats([3, 5, 3, 4], 5))
print(sol.numRescueBoats([3, 2, 3, 2, 2], 6))