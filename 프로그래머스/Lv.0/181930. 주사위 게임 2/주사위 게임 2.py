def solution(a, b, c):
    answer = 0
    check = len(set([a,b,c]))
    if check == 1:
        answer = (a + b + c) * (a**2 + b**2 + c**2) * (a**3 + b**3 + c**3)
    elif check == 3:
        answer = a + b + c
    else:
        answer = (a + b + c) * (a**2 + b**2 + c**2)
    return answer 