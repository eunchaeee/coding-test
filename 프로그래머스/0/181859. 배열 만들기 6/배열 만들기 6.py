def solution(arr):
    stk = []
    i = 0
    while(i<len(arr)):
        if not stk:
            stk.append(arr[i])
            i += 1
        else:
            if stk[-1] == arr[i]:
                stk.pop()
                i += 1
            else:
                stk.append(arr[i])
                i += 1
    return [-1] if not stk else stk