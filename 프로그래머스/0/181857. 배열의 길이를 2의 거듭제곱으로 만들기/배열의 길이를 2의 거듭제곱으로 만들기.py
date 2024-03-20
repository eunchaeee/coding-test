def solution(arr):
    cnt = 0
    l = len(arr)
    while (l > 1):
        if l == 1 :
            return arr
        l /= 2
        cnt += 1
        
    arr.extend([0] * (pow(2,cnt) - len(arr)))
    return arr

