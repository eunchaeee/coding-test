input()
li = list(map(int, input().split()))
li.sort()
answer = 0
for i in range(len(li)+1):
	answer+= sum(li[0:i])

print(answer)