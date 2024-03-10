def solution(arr):
    answer = []
    for i in arr:
        for j in range(0,i):
            answer.append(i)
    return answer