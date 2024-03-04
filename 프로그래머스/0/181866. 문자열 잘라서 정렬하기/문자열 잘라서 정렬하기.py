def solution(myString):
    answer = []
    for i in sorted(myString.split('x')):
        if i != "":
            answer.append(i)
    return answer