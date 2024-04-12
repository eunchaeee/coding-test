def solution(strArr):
    li = [0] * 30
    for i in strArr:
        li[len(i)-1] += 1
    return max(li)