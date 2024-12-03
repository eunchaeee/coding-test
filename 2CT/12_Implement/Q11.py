"""
백준 3190. 뱀
"""

# 보드 생성
n = int(input())
board = [[0] * n for _ in range(n)]

# 사과 위치 기록
k = int(input())
for _ in range(k):
    x, y = map(int, input().split())
    board[x-1][y-1] = 1

# 방향(오른쪽, 아래, 왼쪽, 위)
dx = [1, 0, -1, 0]
dy = [0, -1, 0, 1]

# 게임 시작 전 상태
x = 0
y = 0
rot = 0
length = 1

while True:
    # 전진
    nx = x + dx[rot]
    ny = y + dx[rot]
    if nx < 0 or nx >= n or ny < 0 or ny >= n:
        break
    # 사과가 있거나 내 자신이 있으면 break

# 뱀 이동시키기
l = int(input())  # 뱀의 방향 변환 횟수
for _ in range(l):
    x, c = map(int, input())


