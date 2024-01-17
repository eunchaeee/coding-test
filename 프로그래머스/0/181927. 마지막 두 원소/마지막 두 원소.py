def solution(num_list):
    lastItem = num_list[len(num_list) - 1]
    beforeLastItem = num_list[len(num_list) - 2]
    if lastItem > beforeLastItem:
        num_list.append(lastItem - beforeLastItem)
    else:
        num_list.append(lastItem * 2)
    return num_list