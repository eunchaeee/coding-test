# bfs
from collections import deque

n = int(input().rstrip())

graph = []
for _ in range(n):
    graph.append(list(map(int, input().rstrip())))

dx = [0, 0, 1, -1]
dy = [1, -1, 0, 0]

def bfs(x, y):
    print("BFS ", x, y)
    house = 0
    queue = deque([(x, y)])
    graph[x][y] = 0
    while queue:
        x, y = queue.popleft()
        house += 1
        for k in range(4):
            nx = x + dx[k]
            ny = y + dy[k]
            if nx < 0 or nx >= n or ny < 0 or ny >= n:
                continue
            if graph[nx][ny] == 1:
                graph[nx][ny] = 0
                queue.append((nx, ny))
    return house

count = 0
houses = []
for i in range(n):
    for j in range(n):
        if graph[i][j] == 1:
            count += 1
            h = bfs(i, j)
            houses.append(h)

houses.sort()
print(count)
print("\n".join(map(str, houses)))