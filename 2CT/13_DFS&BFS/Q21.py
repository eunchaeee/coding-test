"""
16234. 인구 이동
"""
# n : 칸 수, l : 최소 인구차, r : 최대 인구차
n, l, r = map(int, input().split())

graph = []
for i in range(n):
    graph.append(list(map(int, input().split())))

def union_checked(i, j):
    global total_union
    answer = False
    for union in total_union:
        if (i, j) in union:
            answer = True
    return answer

def check_people(graph, x, y, union, visited):
    visited[x][y] = True
    print('check_people', x, y, visited)

    dx = [1, -1, 0, 0]
    dy = [0, 0, 1, -1]
    for i in range(4):
        nx = x + dx[i]
        ny = y + dy[i]
        print(nx, ny, visited)

        if nx < 0 or nx >= n or ny < 0 or ny >= n:
            continue
        if visited[nx][ny]:
            continue
        if union_checked(nx, ny):
            continue
        if (nx, ny) in union:
            continue
        #visited[nx][ny] = True

        diff = abs(graph[nx][ny] - graph[x][y])

        if r >= diff >= l:
            union.append((nx, ny))
            check_people(graph, nx, ny, union, visited)
    return union

def union(graph):
    visited = [[False for _ in range(n)] for _ in range(n)]
    global total_union
    for x in range(n):
        for y in range(n):
            if not union_checked(x, y):
                total_union.append(check_people(graph, x, y, [(x, y)], visited))
    return total_union

total_union = []
print(union(graph))