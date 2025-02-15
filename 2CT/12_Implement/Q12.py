"""
기둥과 보 설치
"""

# 만족하지 않는 경우 빼줘야함.

# 기둥 : 1. 바닥 위, 2. 보의 한쪽 끝 부분 위, 3. 다른 기둥 위
# 보 : 1. 한쪽 끝부분이 기둥 위, 2. 양쪽 끝부분이 다른 보

# 설치 할 때는 그 설치 되는 기둥, 보만 조건에 맞는지 살펴보기
# 삭제할 때는 교차되는 부분의 기둥, 보 살펴보기(상세조건 더 뭐가 있을까!!!)

def solution(n, build_frame):
    answer = []
    for x, y, a, b in build_frame:
        if b == 1:  # 설치될 때
            answer.append([x, y, a])
            if not check(answer):
                answer.remove([x, y, a])
        else: # 삭제될 때
            answer.remove([x, y, a])
            if not check(answer):
                answer.append([x, y, a])
    answer.sort(key = lambda x: (x[0], x[1], x[2]))
    return answer

def check(answer):
    for x, y, a in answer:
        if a == 0:  # 기둥일 때
            if y == 0 or [x, y, 1] in answer or [x - 1, y, 1] in answer or [x, y - 1, 0] in answer:
                continue
            return False
        else:  # 보일 때
            if [x, y - 1, 0] in answer or [x + 1, y - 1, 0] in answer or (
                    [x - 1, y, 1] in answer and [x + 1, y, 1] in answer):
                continue
            return False
    return True


print(solution(5, [[1,0,0,1],[1,1,1,1],[2,1,0,1],[2,2,1,1],[5,0,0,1],[5,1,0,1],[4,2,1,1],[3,2,1,1]]))
print(solution(5, [[0,0,0,1],[2,0,0,1],[4,0,0,1],[0,1,1,1],[1,1,1,1],[2,1,1,1],[3,1,1,1],[2,0,0,0],[1,1,1,0],[2,2,0,1]]))