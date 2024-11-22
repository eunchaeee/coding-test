s = input()
li = []
num_sum = 0

for i in s:
    if "A" <= i <= "Z":
        li.append(i)
    elif "0" <= i <= "9":
        num_sum += int(i)

li.sort()
for i in li:
    print(i, end ='')

print(num_sum)