d = [[]] * 6

def solution(l, r):
    minIdx = len(f"{l}")
    maxIdx = len(f"{r}")
    
    unionList = []
    for i in range(minIdx-1,maxIdx):
        unionList.extend(zero_five(i))
    
    answer = list(filter(lambda x:l<=x<=r, unionList))
    
    if not answer:
        return [-1]
    else:       
        answer.sort()
        return answer

def zero_five(n):
    if n == 0:
        d[0] = [5]
        return [5]

    if d[n]:
      return d[n]

    an = []
    for i in zero_five(n-1):
        
        an.append(i*10)
        an.append(i*10+5)
        d[n] = an
    return an