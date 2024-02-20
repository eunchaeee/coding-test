c_sound = ["1","2","3","4","5","6","7","8"]
li = input().split(' ')
if li == sorted(c_sound):
	print("ascending")
elif li == sorted(c_sound, reverse=True):
	print("descending")
else:
	print("mixed")