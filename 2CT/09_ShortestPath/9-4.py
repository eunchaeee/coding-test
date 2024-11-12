"""
2. 미래 도시
"""

import sys
input = sys.stdin.readline
INF = int(1e9)

# 회사 개수 n과 경로 개수 m 입력 받기
n, m = map(int, input().split())

# 2차원 리스트 생성
graph = [[INF] * (n + 1) for _ in range(n + 1)]

# 자기 자신 0으로 초기화
for a in range(1, n + 1):
    for b in range(1, n + 1):
        if a == b:
            graph[a][b] = 0

# 그래프 정보 입력
for _ in range(m):
    a, b = map(int, input().split())
    graph[a][b] = 1
    graph[b][a] = 1

# 소개팅 장소 k와 최종 목적지 x 입력 받기
x, k = map(int, input().split())

# 점화식에 따라 플루이드 워셜 알고리즘 수행
for k in range(1, n + 1):
    for a in range(1, n + 1):
        for b in range(1, n + 1):
            graph[a][b] = min(graph[a][b], graph[a][k] + graph[k][b])

# 수행된 결과 출력
distance = graph[1][k] + graph[k][x]

if distance >= INF:
    print("-1")
else:
    print(distance)


'''
입력 예시
5 7
1 2
1 3
1 4
2 4
3 4
3 5
4 5
4 5
'''