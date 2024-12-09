"""
백준 15686. 치킨 배달
"""
import itertools
import sys
from itertools import combinations

input = sys.stdin.readline
# n : 도시 크기(nxn), m : 남길 치킨집 수
n, m = map(int, input().split())

city = []
chicken = []
houses = []

for _ in range(n):
    city.append(list(map(int, input().split())))

for i in range(n):
    for j in range(n):
        if city[i][j] == 2:
            chicken.append((i, j))
        elif city[i][j] == 1:
            houses.append((i, j))

combs = list(itertools.combinations(chicken, m))
answer = 987654321
for comb in combs:
    total_route = 0
    for h in houses:
        route = 2 * n
        for c in comb:
            c_route = abs(h[0] - c[0]) + abs(h[1] - c[1])
            if c_route < route:
                route = c_route
        total_route += route
    if total_route < answer:
        answer = total_route

print(answer)