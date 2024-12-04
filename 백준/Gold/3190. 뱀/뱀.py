"""
백준 3190. 뱀
"""
import sys
from collections import deque

input = sys.stdin.readline

# 보드 생성
n = int(input().rstrip())

# 사과 위치 기록
apple = []
k = int(input().rstrip())
for _ in range(k):
    x, y = map(int, input().rstrip().split())
    apple.append((x-1, y-1))

# 뱀 이동 경로 받기
move = deque()
l = int(input().rstrip())  # 뱀의 방향 변환 횟수
for _ in range(l):
    x, c = input().rstrip().split()
    move.append((int(x) + 1, c))

# 방향(오른쪽, 아래, 왼쪽, 위)
dx = [0, 1, 0, -1]
dy = [1, 0, -1, 0]

# 게임 시작 전 상태
rot = 0
snake = deque([(0, 0)])
time = 1

while True:
    # 방향 바꿔주기
    if len(move) > 0 and time == move[0][0]:
        t, c = move.popleft()
        if c == 'D':
            rot += 1
        elif c == 'L':
            rot -= 1

        if rot > 3:
            rot = 0
        if rot < 0:
            rot = 3

    # 전진할 칸의 좌표
    x, y = snake[-1]
    nx = x + dx[rot]
    ny = y + dy[rot]
    # 벽에 막혔을 때 중단
    if nx < 0 or nx >= n or ny < 0 or ny >= n:
        print(time)
        break
    # 자기 자신과 부딪혔을 때 중단
    elif (nx, ny) in snake:
        print(time)
        break
    # 공간이 비어있을 때 전진
    elif (nx, ny) not in snake:
        snake.append((nx, ny))
        # 사과가 있으면 길이 늘리기
        if (nx, ny) in apple:
            apple.remove((nx, ny))
        # 사과가 없으면 몸 줄이고 이동
        else:
            snake.popleft()
        time += 1




