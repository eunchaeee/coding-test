def solution(n):
    answer = []
    for i in range(n):
        temp = [0] * n
        temp[i] = 1
        answer.append(temp)
    return answer