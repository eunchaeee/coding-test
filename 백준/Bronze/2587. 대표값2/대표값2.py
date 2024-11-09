array = []
for _ in range(5):
    array.append(int(input()))

result = sorted(array)
print(sum(result)//5)
print(result[2])