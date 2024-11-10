# 3. 떡볶이 떡 만들기
n, m = map(int, input().split())
heights = list(map(int, input().split()))

def binary_search(start, end):
    result = 0
    while start <= end:
        mid = (start + end) // 2
        total = 0
        # 떡의 길이 구하기
        for i in heights:
            if i - mid > 0:
                total += (i - mid)
        # 떡의 길이가 주문 길이보다 작을 경우 끝점을 이동
        if total < m:
            end = mid - 1
        # 떡의 길이가 주문 길이보다 같거나 클 경우 시작점을 이동
        else:
            start = mid + 1
            result = mid
    return result

print(binary_search(0, max(heights)))