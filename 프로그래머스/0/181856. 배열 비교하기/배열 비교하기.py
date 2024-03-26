def solution(arr1, arr2):
    if len(arr1) == len(arr2):
        if sum(arr1) == sum(arr2):
            return 0
        elif sum(arr1) > sum(arr2):
            return 1
        else:
            return -1
    else:
        if len(arr1) > len(arr2):
            return 1
        else:
            return -1
            
            
            
    return answer