import heapq
import sys

input = sys.stdin.readline
INF = int(1e9)

# 도시 개수(n), 통로 개수(m), 메시지 보내는 도시(c)
n, m, c = map(int, input().split())
# 도시 통로 정보
graph = [[] for _ in range(n + 1)]
for i in range(m):
    # x => y (z시간)
    x, y, z = map(int, input().split())
    graph[x].append((y, z))

# 거리 정보
distance = [INF] * (n + 1)

q = []
heapq.heappush(q, (0, c))
distance[c] = 0
while q:
    dist, now = heapq.heappop(q)
    if distance[now] < dist:
        continue
    for (y, z) in graph[now]:
        cost = z + dist
        if distance[y] > cost:
            distance[y] = cost
            heapq.heappush(q, (cost, y))

count = 0
max_distance = 0

for i in distance:
    if i == INF or i == 0:
        continue
    else:
        if max_distance < i:
            max_distance = i
        count += 1

print(count, max_distance)