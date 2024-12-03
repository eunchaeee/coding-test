"""
백준 3190. 뱀
"""
from collections import deque

# 보드 생성
n = int(input())
board = [[0] * n for _ in range(n)]

# 사과 위치 기록
apple = [[0] * n for _ in range(n)]
k = int(input())
for _ in range(k):
    x, y = map(int, input().split())
    apple[x-1][y-1] = 1

# 방향(오른쪽, 아래, 왼쪽, 위)
dx = [1, 0, -1, 0]
dy = [0, -1, 0, 1]

# 게임 시작 전 상태
x = 0
y = 0
rot = 0
length = 1
board[0][0] = 1
snake = deque([(x, y)])

while True:
    # 전진
    nx = x + dx[rot]
    ny = y + dx[rot]
    # 벽에 막혔을 때 중단
    if nx < 0 or nx >= n or ny < 0 or ny >= n:
        break
    # 자기 자신과 부딪혔을 때 중단
    elif board[nx][ny] == 1:
        break
    # 공간이 비어있을 때 전진
    elif board[nx][ny] == 0:
        board[nx][ny] = 1
        head_x = nx
        head_y = ny
        # 사과가 있으면 길이 늘리기
        if apple[nx][ny] == 1:
            length += 1
        # 사과가 없으면 몸 줄이고 이동
        else:
            snake.popleft()
    # 사과가 있거나 내 자신이 있으면 break

# 뱀 이동시키기
l = int(input())  # 뱀의 방향 변환 횟수
for _ in range(l):
    x, c = map(int, input())


