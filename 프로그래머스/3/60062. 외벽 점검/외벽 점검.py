from itertools import permutations

def solution(n, weak, dist):
    m = len(weak)  # 취약 지점 개수
    answer = len(dist) + 1 # 정답은 학생수 + 1 보다 작다.
    # 원형을 선형으로
    weak = weak + [w + n for w in weak]

    # 투입될 친구 순서
    for friends in permutations(dist):
        # 점검 시작 위치
        for idx in range(m):
            # 점검해야할 취약 지점들
            new_weak = weak[idx:idx+m]
            now = new_weak[0]
            # 점검 시작
            # 친구 수
            f_cnt = 0
            for f in friends:
                f_cnt += 1
                # 최소 친구수가 아니면 멈추기
                if f_cnt >= answer:
                    break
                now = now + f
                
                # 끝까지 점검했는가?
                if now >= new_weak[-1]:
                    answer = f_cnt
                    break
                else:
                    # 다음 점검 위치 == 아직 확인 못한 취약 지점 중 가장 가까운 곳
                    for w in new_weak:
                        if w > now:
                            now = w
                            break
                            
    if answer > len(dist):
        return -1
    else:
        return answer
        