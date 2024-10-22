import sys

input = lambda : sys.stdin.readline().rstrip()

# N, M을 공백으로 구분하여 입력받기
n, m = map(int, input().split())
# 2차원 리스트의 맵 정보 입력받기
graph = []
for i in range(n):
    graph.append(list(map(int, input())))

dx = [-1, 1, 0, 0]
dy = [0, 0, 1, -1]

def bfs(x, y):
    # 큐 생성
    queue = [(x, y)]
    # 큐가 소멸될 때까지 반복
    while (queue):
        # popleft
        x, y = queue.pop(0)
        # 다음 원소들 큐에 넣기
        for i in range(4):
            nx = x + dx[i]
            ny = y + dy[i]

            if nx < 0 or ny < 0 or nx >= n or ny >=m:
                continue
            if graph[nx][ny] == 0:
                continue
            if graph[nx][ny] == 1:
                # 큐에 넣기 전에 기록하네
                graph[nx][ny] = graph[x][y] + 1
                queue.append((nx, ny))
    return graph[n-1][m-1]



print(bfs(0, 0))