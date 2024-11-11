"""
3. 개미 전사
"""
# 식량 창고의 개수
n = int(input())
# 식량 현황
food = list(map(int, input().split()))

'''
1 2 3 4 5 6

1   3   5
1   3     6
1     4   6
  2   4   6
  2     5
  
1로 시작 => 3 or 4를 먹는다.
2로 시작 => 4 or 5를 먹는다.
n => n+2 or n+3
a(n) + a(n+2)
?!?!?!?
a(n) = max(a(n-1), a(n-2) + k) 
'''

d = [0] * 100
d[0] = food[0]
d[1] = max(food[0], food[1])
for i in range(2, n):
    d[i] = max(d[i-2] + food[i], d[i-1])

print(d[n-1])