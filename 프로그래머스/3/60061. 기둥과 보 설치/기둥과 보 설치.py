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