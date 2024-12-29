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

combs = list(combinations(zeros, 3))
dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]

final_count = 0

for c in combs:
    copy_graph = copy.deepcopy(graph)
    count = 0
    # 벽 세우기
    for x, y in c:
        copy_graph[x][y] = 1
    for i, j in viruses:
        queue = deque([(i, j)])
        while queue:
            x, y = queue.popleft()
            for i in range(4):
                nx = x + dx[i]
                ny = y + dy[i]

                if nx < 0 or nx >= n or ny < 0 or ny >= m:
                    continue
                if copy_graph[nx][ny] == 0:
                    queue.append((nx, ny))
                    copy_graph[nx][ny] = 2
    for i in range(n):
        for j in range(m):
            if copy_graph[i][j] == 0:
                count += 1
    final_count = max(final_count, count)

print(final_count)