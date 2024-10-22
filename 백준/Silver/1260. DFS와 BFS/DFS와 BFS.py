from collections import deque
import sys

input = sys.stdin.readline

# 정점, 간선, 시작 정점 입력 받기
n, m, v = map(int, input().split())

# 이차원리스트로 그래프 정보 입력 받기
graph = [[] for _ in range(n+1)]
for _ in range(m):
    a, b = map(int, input().split())
    graph[a].append(b)
    graph[b].append(a)

# 방문할 수 있는 정점이 여러 개인 경우에 정점 번호가 작은 것을 먼저 방문
for g in graph:
    g.sort()

# 방문 정보
visited_dfs = [False for _ in range(n+1)]

# DFS
def dfs(graph, v, visited):
    # 방문 처리
    visited[v] = True
    print(v, end = ' ')
    # 현재 노드와 연결된 다른 노드를 재귀적으로 방문
    for i in graph[v]:
        if not visited[i]:
            dfs(graph, i, visited)

dfs(graph, v, visited_dfs)


# BFS
def bfs(graph, start):
    visited = [False for _ in range(n+1)]
    # 큐 생성
    queue = deque([start])
    # 현재 노드 방문 처리
    visited[start] = True
    # 큐가 빌 때까지 반복
    while queue:
        # 큐에서 하나의 원소를 뽑아 출력
        v = queue.popleft()
        print(v, end = ' ')
        # 해당 원소와 연결된, 아직 방문하지 않은 원소들을 큐에 삽입
        for i in graph[v]:
            if not visited[i]:
                queue.append(i)
                visited[i] = True

print()
bfs(graph, v)
    