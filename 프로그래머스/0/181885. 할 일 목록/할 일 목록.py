def solution(todo_list, finished):
    answer = []
    for i, check in enumerate(finished):
        if check == False:
            answer.append(todo_list[i])
    return answer