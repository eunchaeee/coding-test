"""
05. 볼링공 고르기
"""
# 볼링공의 개수(n), 공의 최대 무게(m)
n, m = map(int, input().split())
balls = list(map(int, input().split()))
counts = [0] * (m + 1)

for i in range(1, m + 1):
    counts[i] = balls.count(i)

result = n * (n - 1) // 2

for c in counts:
    if c >= 2:
        result -= (c * (c-1) // 2)

print(result)