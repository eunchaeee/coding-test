# 선택 정렬
array = [7, 5, 9, 0, 3, 1, 6, 2, 4, 8]

for i in range(len(array)):
    # 가장 작은 원소의 인덱스 구하기
    min_index = i   # 초기화
    for j in range(i+1, len(array)):
        if array[min_index] > array[j]:
            min_index = j
    # 가장 작은 원소의 인덱스 구하기 완료

    # i번째 원소와 i+1 이상 번째 원소 중 가장 작은 원소와 swap
    array[i], array[min_index] = array[min_index], array[i]
    # => i번째 원소 오름차순으로 정렬 완료

print(array)