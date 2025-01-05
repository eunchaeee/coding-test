"""
16234. 인구 이동
"""
# n : 칸 수, l : 최소 인구차, r : 최대 인구차
n, l, r = map(int, input().split())

graph = []
for i in range(n):
    graph.append(list(map(int, input().split())))

print(graph)

def union(graph):
    visited = [[False] * n] * n
    dx = [1, -1, 0, 0]
    dy = [0, 0, 1, -1]
    for i in range(n):
        for j in range(n):
            if not visited[i][j]:
                for i in range(4):
                    nx = i + dx[i]
                    ny = j + dy[i]
                    if nx < 0 or nx >= n or ny < 0 or ny >= n:
                        continue
                    diff = abs(graph[i][j] - graph[nx][ny])
                    if diff >= l and diff <= r:
                        

    return

visited = [[False] * n] * n
print(visited)