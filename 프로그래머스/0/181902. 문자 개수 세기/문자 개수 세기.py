def solution(my_string):
    answer = []
    code_A = ord('A')
    code_a = ord('a')
    length = 26
    
    for i in range(code_A, code_A + length):
        answer.append(my_string.count(chr(i)))
        
    for j in range(code_a, code_a + length):
        answer.append(my_string.count(chr(j)))
    return answer