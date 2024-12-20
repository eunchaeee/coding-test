"""
외벽 점검
가장 많은 weak를 포함하는 coverage 구하고, 그 이상의 수가 dist에 있는지 확인하고
없다면 가장 멀리 떨어진거 버리고 반복하기
"""
from itertools import combinations

def solution(n, weak, dist):
    # 간격 구하기
    far = []
    for i in range(len(weak)):
        if i + 1 == len(weak):
            far.append(n - weak[i] + weak[0])
        else:
            far.append(weak[i+1] - weak[i])

    far.index(max(far))
    far.remove(max(far))
    if sum(far) <= dist[-1]:
        return 1
    else:



def solution_old(n, weak, dist):
    # 친구 수를 늘려가면서 생각(몇명으로 커버될지)
    for i in range(1, len(dist)):
        print("친구 수 ", i)
        # 끊어줄 곳 정하기
        min_far = 987654321

        for cut in list(combinations(range(len(weak)),i)):
            # 친구가 1명 필요할 때
            if len(cut) ==  1:
                idx = cut[0]
                if idx == 0:
                    far = weak[idx-1] - weak[idx]
                else:
                    far = n - (weak[idx] - weak[idx-1])
                # 최소로 움직여야 하는 거리 계산
                if min_far  > far:
                    min_far = far
            for d in dist:
                if d >= min_far:
                    return 1
            print(cut)

            # 친구가 2명 이상 필요할 때
    return
    answer = 0
    weak_count = len(weak)
    c = []

    if weak_count == 1:
        answer = 1
    elif weak_count == 2:
        coverage = min(weak[1] - weak[0], n - (weak[1] - weak[0]))
        for i in dist:
            if i >= coverage:
                return 1
            else:
                if len(dist) >= 2:
                    return 2
                else:
                    return -1
    else:
        for i in range(weak_count):
            if i == weak_count - 1:
                c.append(weak[i] - weak[0])
            c.append(weak[i+1] - weak[i])
    return answer


print(solution(12, [1, 5, 6, 10], [1, 2, 3, 4])) # 2
print(solution(12, [1, 3, 4, 9, 10], [3, 5, 7])) # 1