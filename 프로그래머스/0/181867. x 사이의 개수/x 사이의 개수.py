def solution(myString):
    answer = []
    cnt = 0
    for i in myString:
        if i =="x":
            answer.append(cnt)
            cnt = 0
        else:
            cnt+=1
    answer.append(cnt)
    return answer