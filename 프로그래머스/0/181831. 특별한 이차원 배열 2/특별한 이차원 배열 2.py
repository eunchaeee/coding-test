import math

def solution(arr):
    answer = 0
    for i in range(math.ceil(len(arr)/2)):
        for j in range(len(arr)):
            if arr[i][j] != arr[j][i]:
                return 0
    return 1