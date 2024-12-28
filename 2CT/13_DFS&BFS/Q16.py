"""
14502. 연구소
"""
import copy
import sys
from itertools import combinations
from collections import deque

input = sys.stdin.readline

n, m = map(int, input().split())
graph = []

for _ in range(n):
    graph.append(list(map(int, input().split())))

# 0인 위치 값들, 2인 위치 값들 각각 저장
zeros = []
viruses = []

for i in range(n):
    for j in range(m):
        if graph[i][j] == 0:
            zeros.append((i, j))
        elif graph[i][j] == 2:
            viruses.append((i, j))

origin_graph = copy.deepcopy(graph)
#print(graph)
print(zeros)
print(viruses)


combs = list(combinations(zeros, 3))

dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]

final_count = 0

for c in combs:
    graph = origin_graph
    count = 0
    # 벽 세우기
    for x, y in c:
        graph[x][y] = 1
    print('초기', graph)
    for i, j in viruses:
        queue = deque([(i, j)])
        while queue:
            x, y = queue.popleft()
            for i in range(4):
                nx = x + dx[i]
                ny = y + dy[i]

                if nx < 0 or nx >= n or ny < 0 or ny >= m:
                    continue
                if graph[nx][ny] == 0:
                    queue.append((nx, ny))
                    graph[nx][ny] = 2
    print(graph)
    for i in range(n):
        for j in range(m):
            if graph[i][j] == 0:
                count += 1
    final_count = max(final_count, count)

print(final_count)