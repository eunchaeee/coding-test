"""
18405. 경쟁적 전염
"""
import heapq

# n : 그래프 크기, k : 바이러스 종류
n, k = map(int, input().split())
graph = []
for _ in range(n):
    graph.append(list(map(int, input().split())))

# s : 시간
s, x, y = map(int, input().split())

dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]

viruses = []

for i in range(n):
    for j in range(n):
        if graph[i][j] != 0:
            heapq.heappush(viruses, (graph[i][j],(i, j)))

while s > 0:
    temp = []
    while viruses:
        virus = heapq.heappop(viruses)
        v, (vx, vy) = virus
        for i in range(4):
            nx = vx + dx[i]
            ny = vy + dy[i]
            if nx < 0 or nx >= n or ny < 0 or ny >= n:
                continue
            if graph[nx][ny] == 0:
                graph[nx][ny] = graph[vx][vy]
                heapq.heappush(temp, (graph[nx][ny], (nx, ny)))
    viruses.extend(temp)
    s -= 1

print(graph[x-1][y-1])