def solution(arr):
    answer = 0
    new_arr = []
    while True:
        new_arr = []
        for a in arr:
            if a >= 50 and a % 2 == 0:
                new_arr.append(a/2)
            elif a <50 and a%2==1:
                new_arr.append(a*2 +1)
            else:
                new_arr.append(a)
        if arr == new_arr:
            return answer
        else:
            answer+=1
            arr = new_arr