def solution(a, b, c, d):
    answer = 0
    li = [a,b,c,d]
    dict = {}
    for i in range(1, 7):
        cnt = li.count(i)
        if cnt != 0:
            if cnt == 2 and 2 in dict:
                return (dict[2] + i) * abs(dict[2] - i)            
            dict[li.count(i)] = i
    
    if 4 in dict:
        answer = dict[4] * 1111
    elif 3 in dict:
        answer = (10 * dict[3] + dict[1])**2
    elif 2 in dict:
        li.remove(dict[2])
        li.remove(dict[2])
        answer = li[0] * li[1]  
    else:
        answer = min(li)
    return answer