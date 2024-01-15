def solution(num_list):
    odd = ""
    even = ""
    for i in num_list:
        if i%2 == 0:
            even += f"{i}"
        else:
            odd += f"{i}"
    return int(odd) + int(even)