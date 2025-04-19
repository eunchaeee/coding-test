from typing import List


class Solution:
    def maxIceCream(self, costs: List[int], coins: int) -> int:
        # counts 배열 생성
        counts = [0] * (max(costs) + 1)

        # 개수 세기
        for i in costs:
            counts[i] += 1

        # 누적합(인덱스 용도)
        for i in range(len(counts) - 1):
            counts[i+1] += counts[i]

        # 정렬
        sorted_costs = [0] * len(costs)
        for i in range(len(costs) - 1, -1, -1):
            idx = counts[costs[i]] - 1
            sorted_costs[idx] = costs[i]
            counts[costs[i]] -= 1

        answer = 0
        for i in range(len(sorted_costs)):
            coins -= sorted_costs[i]
            if coins < 0:
                break
            answer += 1
        return answer




sol = Solution()
print(sol.maxIceCream([1, 3, 2, 4, 1], 7))
print(sol.maxIceCream([10, 6, 8, 7, 7, 8], 5))
print(sol.maxIceCream([1, 6, 3, 1, 2, 5], 20))
