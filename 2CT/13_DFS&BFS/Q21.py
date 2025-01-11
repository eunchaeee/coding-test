"""
16234. 인구 이동
"""
from collections import deque
import sys

input = sys.stdin.readline
n, l, r = map(int, input().split())

graph = []
for _ in range(n):
    graph.append(list(map(int, input().split())))

def bfs(graph, x, y, visited):
    dx = [1, -1, 0, 0]
    dy = [0, 0, 1, -1]

    queue = deque([(x, y)])
    union = [(x, y)]
    visited[x][y] = True
    while queue:
        x, y = queue.popleft()
        for i in range(4):
            nx = x + dx[i]
            ny = y + dy[i]
            if nx < 0 or nx >= n or ny < 0 or ny >= n:
                continue
            diff = abs(graph[nx][ny] - graph[x][y])
            if not visited[nx][ny]:
                if l <= diff <= r:
                    union.append((nx, ny))
                    queue.append((nx, ny))
                    visited[nx][ny] = True
    return union

count = 0
visited = [[False for _ in range(n)] for _ in range(n)]

while True:
    total_union = []
    visited = [[False for _ in range(n)] for _ in range(n)]

    for i in range(n):
        for j in range(n):
            if not visited[i][j]:
                u = bfs(graph, i, j, visited)
                if len(u) > 0:
                    total_union.append(u)

    if len(total_union) == 0 or len(total_union) == n * n:
        break
    elif len(total_union) < n * n:
        count += 1

    for union in total_union:
        average = 0

        for x, y in union:
            average += graph[x][y]
        for x, y in union:
            graph[x][y] = int(average/len(union))
print(count)