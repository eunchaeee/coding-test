def right_letters(p):
    check = 0
    for i in range(len(p)):
        if check < 0:
            return False
        if p[i] == '(':
            check += 1
        else:
            check -= 1
    return True

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

    if right_letters(u):
        return u + solution(v)
    else:
        tu = ""
        if len(u) > 2:
            for i in u[1:-1]:
                if i == '(':
                    tu += ')'
                else:
                    tu += '('
        return '(' + solution(v) + ')' + tu