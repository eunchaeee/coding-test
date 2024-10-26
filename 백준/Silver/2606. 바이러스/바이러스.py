import sys

input = sys.stdin.readline
node = int(input().rstrip())
edge = int(input().rstrip())

graph = [[] for _ in range(node+1)]

for _ in range(edge):
    a, b = map(int, input().split())
    graph[a].append(b)
    graph[b].append(a)

visited = [False] * (node + 1)

def bfs(start):
    queue = [start]
    visited[start] = True
    count = 0
    while queue:
        v = queue.pop(0)
        for i in graph[v]:
            if not visited[i]:
                queue.append(i)
                visited[i] = True
                count += 1
    print(count)

bfs(1)