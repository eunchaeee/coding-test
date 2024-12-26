"""
14502. 연구소
"""
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
            zeros.append((i + 1, j + 1))
        elif graph[i][j] == 2:
            viruses.append((i + 1, j + 1))

#print(graph)
# print(zeros)
#print(viruses)


combs = list(combinations(zeros, 3))

for c in combs:
    for x, y in c:
        graph[x][y] = 1
    for i, j in viruses:
        queue = deque()
        queue.append((i, j))
        while queue:
            now = queue.popleft()
