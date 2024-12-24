"""
외벽 점검
가장 많은 weak를 포함하는 coverage 구하고, 그 이상의 수가 dist에 있는지 확인하고
없다면 가장 멀리 떨어진거 버리고 반복하기
"""
from itertools import combinations
from collections import deque
import copy

def solution(n, weak, dist):
    # 간격(apart) 구하기
    apart = deque()
    for i in range(len(weak)):
        if i + 1 == len(weak):
            apart.append(n - weak[i] + weak[0])
        else:
            apart.append(weak[i+1] - weak[i])

    # dist에 원소가 남아있으면 계속 진행
    while dist:
        # 가장 큰 dist 꺼내기
        current_dist = dist.pop()
        count = 0
        indices = []
        # apart의 첫 원소부터 계산해서 current_dist 를 안넘는 가장많은 원소로 이루어진 숫자쌍 구하기
        print("current_dist ", current_dist)
        for i in range(len(apart)):
            copy_apart = copy.deepcopy(apart)
            copy_apart.rotate(-1)
            print(copy_apart)
            sum = 0
            apart_elements = []
            for j in range(len(copy_apart)):
                temp_sum = 0
                temp_apart_elements = []
                if temp_sum + copy_apart[j] > current_dist:
                    print(sum, apart_elements)
                    if len(apart_elements) > len(temp_apart_elements):
                        sum = temp_sum
                        apart_elements = temp_apart_elements
                    elif len(apart_elements) == len(temp_apart_elements):
                        print("!!!", copy_apart)

                    break
                else:
                    copy_apart.remove(copy_apart[j])
                    temp_sum += copy_apart[j]
                    apart_elements.append(copy_apart[j])


        return

        for start in range(len(apart)):
            sum = 0
            i = 0
            num_list = []
            # 여기서 start + i 가 전체 인덱스 개수보다 커졌을 때 0부터 초기화되도록 해야하고, 이때 초기화한 인덱스가 start를 넘어서면 지금까지 사용한? 친구의 수만큼 return.
            while True:
                # 다음 원소를 더한 것이 현재 친구의 이동거리(current_dist)보다 커지면 break
                if sum + apart[start + i] > current_dist:
                    break
                # 그렇지 않으면 다음 원소도 더한다.
                else:
                    sum += apart[start + i]
                    num_list.append(apart[start + i])
                    i += 1
            print(dist, start, start+i, sum, num_list)
            # i+1는 원소 개수가 됨.
            # indices = list(range(start, i+1))
            # if count < i + 1:
            #     count = i + 1
            # elif count == i + 1:




    return -1



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
#print(solution(12, [1, 3, 4, 9, 10], [3, 5, 7])) # 1