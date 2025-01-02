"""
14888. 연산자 끼워넣기
"""
from itertools import permutations
import sys
input = sys.stdin.readline

# 수의 개수
n = int(input().rstrip())  # 연산자의 개수 : n-1

numbers = list(map(int, input().split()))
operator_counts = list(map(int, input().split()))

operators = []
for i in range(4):
    for _ in range(operator_counts[i]):
        operators.append(i)

max_answer = -1e10
min_answer = 1e10

for perms in list(permutations(operators)):
    answer = numbers[0]
    for i in range(n-1):
        if perms[i] == 0:
            answer += numbers[i+1]
        elif perms[i] == 1:
            answer -= numbers[i+1]
        elif perms[i] == 2:
            answer *= numbers[i+1]
        else:
            if answer < 0:
                answer = abs(answer) // numbers[i+1]
                answer = -answer
            else:
                answer = answer // numbers[i+1]
    if max_answer < answer:
        max_answer = answer
    if min_answer > answer:
        min_answer = answer

print(max_answer)
print(min_answer)