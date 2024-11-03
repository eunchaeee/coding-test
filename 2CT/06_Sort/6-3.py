# 삽입 정렬 소스코드
array = [7, 5, 9, 0, 3, 1, 6, 2, 4, 8]

for i in range(1, len(array)):  # 0번째 원소는 정렬되어있다고 가정하고, 1번째 원소부터 정렬
    for j in range(i, 0, -1):
        if array[j] < array[j-1]:   # i번째 원소를 i-1번째와 비교해서 i번째가 더 작으면 Swap => 다음은 i-1번째와 i-2번째를 비교
            array[j], array[j-1] = array[j-1], array[j]
        else:
            break
print(array)