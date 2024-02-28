def solution(strArr):
    answer = []
    for s in strArr:
        if s.find("ad") == -1:
            answer.append(s)
    return answer