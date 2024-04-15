def solution(rank, attendance):
    answer = 0
    temp = [0] * len(rank)
    
    for i in range(len(rank)):
        temp[i] = rank[i] * int(attendance[i])
    
    li = []
    for i in range(1,len(rank)+1):
        if i in temp:
            li.append(temp.index(i))
            if len(li) == 3:
                break
    answer = 10000 * li[0] + 100 * li[1] + li[2]
    return answer