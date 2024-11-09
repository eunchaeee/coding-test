"""
2. 부품 찾기 : 이진 탐색 이용
"""
def binary_search(array, target, start, end):
    while start <= end:
        mid = (start + end) // 2
        if array[mid] == target:
            print("yes", end=' ')
            return
        elif array[mid] < target:
            start = mid + 1
        else:
            end = mid - 1
    print("no", end=' ')
    return

n = int(input())
comp = list(map(int, input().split()))
m = int(input())
req = list(map(int, input().split()))

comp.sort()

for r in req:
    binary_search(comp, r, 0, n)
