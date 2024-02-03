def solution(my_string, m, c):
    answer = ''
    idx = c-1
    while idx <= len(my_string) -1:
        answer+= my_string[idx]
        idx+=m
    return answer