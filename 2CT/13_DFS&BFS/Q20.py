"""
18428. 감시 피하기
"""
from itertools import combinations
import copy
import sys
input = sys.stdin.readline

# 복도의 크기 n
n = int(input().rstrip())
# 그래프 입력 받기
graph = []
for _ in range(n):
    graph.append(input().split())

# 선생님 좌표 저장
teachers = []
for i in range(n):
    for j in range(n):
        if graph[i][j] == 'T':
            teachers.append((i, j))

# find_student 함수
def find_student(graph, x, y, dx, dy):
    global candidates
    # nx, ny 좌표
    nx = x + dx
    ny = y + dy
    # 범위를 넘어갔을 때 return False
    if nx < 0 or nx >= n or ny < 0 or ny >= n:
        return False
    # 벽을 마주쳤을 때 return False
    elif graph[nx][ny] == "O":
        return False
    # 빈 공간일 때 다음 칸으로 이동
    elif graph[nx][ny] == "X":
        return find_student(graph, nx, ny, dx, dy)
    # 학생을 만났을 때 return True
    elif graph[nx][ny] == "S":
        return True

def solution(teachers, graph):
    # 선생님 이동 방향
    dx = [1, -1, 0, 0]
    dy = [0, 0, 1, -1]
    # 벽을 세울 수 있는 후보 집합
    candidates = set()
    # answer 디폴트 값 = "NO"
    answer = "NO"
    # 각 선생님 좌표를 기준으로 벽을 세울 수 있는 후보 좌표 추가하기
    for x, y in teachers:
        # 네 가지 방향으로 조사
        for i in range(4):
            nx = x + dx[i]
            ny = y + dy[i]
            # 바로 다음 좌표가 범위를 벗어나면 넘어 간다.
            if nx < 0 or ny < 0 or nx >= n or ny >= n:
                continue
            # 바로 다음 좌표가 학생이면 return "NO"
            elif graph[nx][ny] == "S":
                return answer
            # 직선 상으로 학생이 있으면 바로 다음 칸을 후보에 추가
            elif find_student(graph, x, y, dx[i], dy[i]):
                candidates.add((x + dx[i], y + dy[i]))

    for combs in list(combinations(candidates, 3)):
        # 그래프 카피하기
        graph_copied = copy.deepcopy(graph)
        # 장애물 세우기
        graph_copied[combs[0][0]][combs[0][1]] = 'O'
        graph_copied[combs[1][0]][combs[1][1]] = 'O'
        graph_copied[combs[2][0]][combs[2][1]] = 'O'
        answer = "YES"
        # 각 선생님 별로 학생 확인하기
        for tx, ty in teachers:

            # 네 방향에 대해 확인
            for i in range(4):
                # 학생 발견 시 answer = "NO"로 바꾸고 break
                if find_student(graph_copied, tx, ty, dx[i], dy[i]):
                    answer = "NO"
                    break
            # 학생 발견되었으므로 이번 경우 탈출
            if answer == "NO":
                break

        if answer == "YES":
            return answer

print(solution(teachers, graph))