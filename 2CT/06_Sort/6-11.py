# 3. 성적이 낮은 순서로 학생 출력하기
n = int(input())
array = []

for _ in range(n):
    (a, b) = input().split()
    array.append((a, b))

result = sorted(array, key = lambda x : x[1])

for i in result:
    print(i[0], end=' ')