n_list = list(map(int, input()))
mid = len(n_list)//2
if sum(n_list[:mid]) == sum(n_list[mid:]):
    print("LUCKY")
else:
    print("READY")