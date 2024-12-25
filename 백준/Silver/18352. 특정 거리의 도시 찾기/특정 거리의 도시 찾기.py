"""
백준 18352 : 특정 거리의 도시 찾기
"""
from collections import deque
import sys

input = sys.stdin.readline
n, m, k, x = map(int, input().split())
graph = [[] for _ in range(n+1)]

for _ in range(m):
    a, b = map(int, input().split())
    graph[a].append(b)

INF = 987654321
dist = [INF for _ in range(n + 1)]
dist[x] = 0
queue = deque()
queue.append(x)

while queue:
    now = queue.popleft()
    for i in graph[now]:
        if dist[i] == INF:
            queue.append(i)
            dist[i] = dist[now] + 1

if dist.count(k) <= 0:
    print(-1)
else:
    for j in range(len(dist)):
        if dist[j] == k:
            print(j)