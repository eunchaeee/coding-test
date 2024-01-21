def solution(arr, queries):
    answer = []
    for (s, e, k) in queries:
        newList = list(filter(lambda x : x > k, arr[s:e+1]))
        if not newList:
            answer.append(-1)
        else:
            answer.append(min(newList))
    return answer