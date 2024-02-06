def solution(arr):
    try:
        first_idx = arr.index(2)
        arr = arr[first_idx:]
        arr.reverse()
        second_idx = arr.index(2)
        arr = arr[second_idx:]
        arr.reverse()
        return arr
        
    except:
        return [-1]
    