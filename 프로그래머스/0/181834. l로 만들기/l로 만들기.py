def solution(myString):
    answer = ''
    for i in myString:
        if i <"l":
            answer += "l"
        else:
            answer += i
    return answer