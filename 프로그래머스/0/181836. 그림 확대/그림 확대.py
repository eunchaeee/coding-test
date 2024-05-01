def solution(picture, k):
    answer = []
    for p in picture:
        line = ""
        for i in p:
            line += i * k
            
        for j in range(k):    
            answer.append(line)
    return answer