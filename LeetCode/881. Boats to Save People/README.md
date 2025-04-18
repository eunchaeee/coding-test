# LeetCode 881. Boats to Save People

## 🔗 문제링크
https://leetcode.com/problems/boats-to-save-people/description/

## 풀이
### 처음 풀이
```python
from typing import List

class Solution:
    def numRescueBoats(self, people: List[int], limit: int) -> int:
        # people 내림차순 정렬
        people.sort(reverse=True)
        count = 0
        # 보트 태우기
        while people:
            people = self.rescue(people, limit)
            count += 1
        return count

    def rescue(self, people, limit):
        weight = limit
        ppl = people.copy()
        count = 0
        for p in people:
            if count == 2:
                return ppl
            if weight < ppl[-1]:
                return ppl
            if weight >= p:
                ppl.remove(p)
                weight -= p
                count += 1
            elif weight < p:
                continue
        return ppl
```

- 매번 무거운 사람 하나를 고정하고, 나머지 사람 중 누가 같이 탈 수 있을까를 무거운 순서대로 탐색

## 문제점
1. people.copy()로 매번 리스트 복사 → O(n)

2. ppl.remove(p) → O(n)

3. 매 루프마다 위 연산 반복 → 총 시간복잡도는 O(n²) 수준

4. 사실상 투 포인터 방식을 쓰면 더 빠르게 해결할 수 있어.


## Two Pointer 방식
가장 무게가 큰 사람을 일단 태우고, 가장 무게가 가벼운 사람이 같이 탈 수 있는지 체크한다.

### Two Pointer-Greedy 방식이 항상 최적해인가?
- 오름차순으로 배열된 `people = {a, b, ..., y, z}` 와 `limit` 가 있을 때
- 의문 : a + z (가능), b + y (불가능), a + y (가능) 일 때, b + z 가 가능하면 z는 꼭 가장 가벼운 사람하고만 타지 않아도 되지 않을까?
- 결론: b + y 가 불가능이므로 b + z 도 불가능. 따라서 그냥 가장 가벼운 사람이 탈 수 있는지만 체크하면 됨.

### 시간복잡도
- `O(n log n)` — 정렬<b>(병목)</b>
- `O(n)` — 투 포인터 이동
- 총 `O(n log n)`
