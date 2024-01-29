def solution(my_string, queries):
    str = ""
    for (s, e) in queries:
        switching = ""
        for i in range(e, s-1, -1):
            switching += my_string[i]
        str =  my_string[0:s] + switching + my_string[e+1:]
        my_string = str
    return my_string