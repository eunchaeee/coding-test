def solution(num_list):
    return max(sum(num_list[0::2]),sum(num_list[1::2]))