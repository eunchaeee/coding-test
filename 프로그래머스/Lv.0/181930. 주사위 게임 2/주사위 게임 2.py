def solution(a, b, c):
    answer = 0
    if a == b == c:
        answer = (a + b + c) * (a**2 + b**2 + c**2) * (a**3 + b**3 + c**3)
    elif a != b != c != a:
        answer = a + b + c
    else:
        answer = (a + b + c) * (a**2 + b**2 + c**2)
    return answer 