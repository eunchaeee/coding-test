import sys

input = sys.stdin.readline

def find_parent(parent, x):
    if parent[x] != x:
        parent[x] = find_parent(parent, parent[x])
    return parent[x]

def union_parent(parent, a, b):
    a = find_parent(parent, a)
    b = find_parent(parent, b)
    if a < b:
        parent[b] = a
    else:
        parent[a] = b

n, m = map(int, input().rstrip().split())

edges = []
parent = [0] * (n + 1)

for i in range(n + 1):
    parent[i] = i

# 간선 정보 입력
for _ in range(m):
    a, b, cost = map(int, input().rstrip().split())
    edges.append((cost, a, b))

# 간선 정렬
edges.sort()

result = 0
largest = 0
for cost, a, b in edges:
    if find_parent(parent, a) != find_parent(parent, b):
        union_parent(parent, a, b)
        result += cost
        largest = cost

print(result - largest)