"""
5-11.py 미로 탈출
"""
import sys
from collections import deque

input = sys.stdin.readline
n, m = map(int, input().split())
graph = []
for _ in range(n):
    graph.append(list(map(int, input().rstrip())))

dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]

queue = deque([(0, 0)])
while queue:
    x, y = queue.popleft()
    for i in range(4):
        nx = x + dx[i]
        ny = y + dy[i]
        if nx < 0 or nx >= n or ny < 0 or ny >= m:
            continue
        if nx == 0 and ny == 0:
            continue
        elif graph[nx][ny] == 1:
            queue.append((nx, ny))
            graph[nx][ny] = graph[x][y] + 1

print(graph[n-1][m-1])

"""
input
5 6
101010
111111
000001
111111
111111
"""
