# 반복문으로 구현한 이진탐색
from unittest import removeResult


def binary_search(arr, target, start, end):
    while start <= end:
        mid = (start + end) // 2
        # 찾은 경우 중간점 인덱스 반환
        if arr[mid] == target:
            return mid
        elif arr[mid] > target:
            end = mid - 1
        else:
            start = mid + 1
    return None


# n(원소의 개수)과 target(찾고자 하는 문자열)을 입력 받기
n, target = list(map(int, input().split()))
# 전체 원소 입력 받기
arr = list(map(int, input().split()))

# 이진 탐색 수행 결과 출력
result = binary_search(arr, target, 0, n - 1)
if result is None:
    print("원소가 존재하지 않습니다.")
else:
    print(result + 1)