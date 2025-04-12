from typing import List
from collections import deque, defaultdict

'''
1. 터미널 노드 조사
2. 각 리스트에서 터미널 인덱스 제거
3. 터미널 노드 조사

'''

class Solution:
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

print(Solution.eventualSafeNodes(Solution, [[1,2],[2,3],[5],[0],[5],[],[]]))