# 1920. 수 찾기
import sys
input = sys.stdin.readline

def binary_search(arr, t, start, end):
    while start <= end:
        mid = (start + end) // 2
        if arr[mid] == t:
            return 1
        elif arr[mid] < t:
            start = mid + 1
        else:
            end = mid - 1
    return 0

n = int(input().rstrip())
a = list(map(int, input().rstrip().split()))
m = int(input().rstrip())
b = map(int, input().rstrip().split())

a.sort()
for i in b:
    print(binary_search(a, i, 0, n - 1))