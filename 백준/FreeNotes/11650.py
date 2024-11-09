# 11650. 좌표 정렬하기
n = int(input().rstrip())
arr = []

for _ in range(n):
    x, y = map(int, input().rstrip().split())
    arr.append((x, y))

result = sorted(arr, key = lambda point: (point[0], point[1]))

for i in result:
    print(i[0], i[1])