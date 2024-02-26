def solution(strArr):
    answer = []
    for i, x in enumerate(strArr):
        if i%2==0:
            answer.append(x.lower())
        else:
            answer.append(x.upper())            
    return answer