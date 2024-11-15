"""
01. 모험가 길드
"""
# 모험가의 수(n)
n = int(input())
fearness = list(map(int, input().split()))

fearness.sort()
i = 0
count = 0
while i < n:
    if i + fearness[i] >= n:
        break
    i += fearness[i]
    count += 1

print(count)