# dfs
n = int(input().rstrip())

graph = []
for _ in range(n):
    graph.append(list(map(int, input().rstrip())))

def dfs(x, y):
    house = 0
    if x < 0 or x >= n or y < 0 or y >= n:
        return house
    if graph[x][y] == 1:
        graph[x][y] = 0
        house += 1
        house +=  dfs(x+1, y) + dfs(x-1, y) + dfs(x, y-1) + dfs(x, y+1)
        return house
    return house

count = 0
houses = []

# dfs 는 스택 구조이기 때문에 중복되지가 않음.
for i in range(n):
    for j in range(n):
        h = dfs(i, j)
        if h != 0:
            houses.append(h)
            count += 1

houses.sort()
print(count)
for h in houses:
    print(h)