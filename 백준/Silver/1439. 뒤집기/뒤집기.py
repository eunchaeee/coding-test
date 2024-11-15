count_one = 0
count_zero = 0
now = -1
for i in input():
    if i == '0' and now != 0:
        count_zero += 1
        now = 0
    elif i == '1' and now != 1:
        count_one += 1
        now = 1

print(min(count_one, count_zero))