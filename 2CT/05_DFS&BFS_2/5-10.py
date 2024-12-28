"""
5-10.py 음료수 얼려 먹기
"""
import sys
from collections import deque

input = sys.stdin.readline
dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]

def bfs(graph, i, j):
    queue = deque([(i, j)])
    graph[i][j] = 1
    while queue:
        x, y = queue.popleft()
        for k in range(4):
            nx = x + dx[k]
            ny = y + dy[k]
            if nx >= n or nx < 0 or ny >= m or ny < 0:
                continue
            if graph[nx][ny] == 0:
                queue.append((nx, ny))
                graph[nx][ny] = 1
    return True

n, m = map(int, input().split())
graph = []
for _ in range(n):
    graph.append(list(map(int, input().rstrip())))

count = 0
for i in range(n):
    for j in range(m):
        if graph[i][j] == 0:
            bfs(graph, i, j)
            count += 1

print(count)


"""
input
15 14
00000111100000
11111101111110
11011101101110
11011101100000
11011111111111
11011111111100
11000000011111
01111111111111
00000000011111
01111111111000
00011111111000
00000001111000
11111111110011
11100011111111
11100011111111
"""