def solution(intStrs, k, s, l):
    answer = []
    for intStr in intStrs:
        intResult = int(intStr[s:s+l])
        if intResult > k:
            answer.append(intResult)
    return answer