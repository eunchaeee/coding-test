"""
괄호변환(프로그래머스)
"""
def solution(p):
    if p == "":
        return p

    # p를 u, v로 분리하기
    l_count = 0
    r_count = 0
    u = ''
    v = ''
    for i in range(len(p)):
        if l_count == r_count and l_count != 0:
            v = p[i:]
            break
        if p[i] == '(':
            l_count += 1
            u += p[i]
        else:
            r_count += 1
            u += p[i]
    print('u :', u, 'v :', v)
    answer = ''
    return answer