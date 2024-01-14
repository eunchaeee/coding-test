def solution(num_list):
    s = 0;
    m = 1;
    for i in num_list:
        s += i
        m *= i
    return int(s**2 > m)