def solution(myString, pat):
    for i in range(len(myString),0,-1):
        if myString[0:i].endswith(pat):
            return myString[0:i]