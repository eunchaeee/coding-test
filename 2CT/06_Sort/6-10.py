# 2. 위에서 아래로
n = int(input())
array = []

for _ in range(n):
    array.append(int(input()))

array.sort(reverse=True)

for i in array:
    print(i, end=' ')