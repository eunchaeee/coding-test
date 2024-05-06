def solution(arr):
    row_len = len(arr)
    col_len = len(arr[0])
    if row_len > col_len:
        for i in arr:
            for j in range(row_len - col_len):
                i.append(0)
        return arr
    elif row_len < col_len:
        for i in range(col_len - row_len):
            arr.append([0] * col_len)
        return arr
    else:
        return arr