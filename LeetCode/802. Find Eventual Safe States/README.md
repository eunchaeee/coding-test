# LeetCode 802. Find Eventual Safe States

## 🔗 문제링크
https://leetcode.com/problems/find-eventual-safe-states/description/

##  💻 첫 번째 풀이

```python
    def eventualSafeNodes2(self, graph: List[List[int]]) -> List[int]:
        answer = []
        # 1회전
        found = True
        while True:
            if (not found):
                break
            found = False
            # 그래프 돌면서 터미널 노드 찾기
            for i in range(len(graph)):
                # 터미널 노드 찾았으면
                if graph[i] == []:
                    graph[i].append(-1)
                    found = True
                    answer.append(i)
                    # 각 리스트에서 터미널 노드 인덱스 제거
                    for j in range(len(graph)):
                        if i in graph[j]:
                            graph[j].remove(i)
        answer.sort()
        return answer
```

## 💡 아이디어 요약
graph = [[1,2],[2,3],[5],[0],[5],[],[]]
- 터미널 노드([])를 발견하면:
  - -1을 추가해서 다시는 처리 안 하게 만들고
  - 그 노드를 가리키는 다른 노드의 리스트에서 제거
- found가 없을 때까지 반복 (즉, 계속 도미노처럼 터미널 찾아감)

## 🧪 결과
시간 초과

## ⏱ 시간 복잡도 분석
- `바깥 while 루프` : 최대 V번 반복 (V는 노드 수)
- `첫 번째 for문` : 모든 노드를 한 번씩 돌면서 터미널 노드인지 확인. <b>루프 당 O(V)</b>
- `두 번째 for문`
  - 모든 노드를 돌면서(총 V개)
  - 맞는 인덱스가 있는지 확인 (리스트 in 연산) : <b>O(K)</b> (K는 각 노드의 out-degree)
  - 맞는 인덱스가 있다면 제거한다.(remove 연산) :  <b>O(K)</b>

=> 🔥 최종 시간복잡도: O(V³)

## ✅ Tip
### list vs set의 `in` 연산 비교

| 타입       | `in` 연산 복잡도 | 설명                                     |
|------------|------------------|------------------------------------------|
| `list`     | **O(N)**         | 앞에서부터 하나하나 비교해야 돼         |
| `set`, `dict` | **O(1)**     | 내부적으로 해시 테이블로 구현돼 있어서 바로 찾아냄 |


##  💻 수정한 풀이
```python
from typing import List
from collections import deque, defaultdict

    def eventualSafeNodes(self, graph: List[List[int]]) -> List[int]:
        n = len(graph)
        out_degree = [0] * n
        reversed_graph = defaultdict(list)

        # 1. 그래프를 역방향으로 만들고, 각 노드의 out-degree 계산
        for u in range(n):
            for v in graph[u]:
                reversed_graph[v].append(u)
                out_degree[u] += 1

        # 2. out-degree 가 0인 노드 (터미널 노드) 큐에 추가
        queue = deque([i for i in range(n) if out_degree[i] == 0])
        safe = [False] * n

        # 3. 큐 돌리기(역방향 위상정렬)
        while queue:
            node = queue.popleft()
            safe[node] = True  # 이 노드는 안전하다고 표시
            for prev in reversed_graph[node]:  # 역방향 : 나로 들어오던 노드들
                out_degree[prev] -= 1
                if out_degree[prev] == 0:
                    queue.append(prev)

        # 4. 안전한 노드들만 뽑아서 정렬된 리스트로 리턴
        return [i for i, v in enumerate(safe) if v]
```