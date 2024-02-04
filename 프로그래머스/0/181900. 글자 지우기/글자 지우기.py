def solution(my_string, indices):
    answer = ''
    full_idx = list(range(len(my_string)))
    answer_idx = list(set(full_idx) - set(indices))
    answer_idx.sort()
    for i in answer_idx:
        answer+= my_string[i]
    return answer