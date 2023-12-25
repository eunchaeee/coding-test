str = input()
for i in str:
    if i.islower():
        print(i.upper(), end="")
    else:
        print(i.lower(), end="")