def solution(date1, date2):
    answer = 0
    for i in range(3):
        if date1[i]< date2[i]:
            return 1
        elif date1[i] > date2[i]:
            return 0
        else:
            continue
    return 0