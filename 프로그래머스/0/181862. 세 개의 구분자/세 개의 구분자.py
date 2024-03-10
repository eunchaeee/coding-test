def solution(myStr):
    answer = []
    word = ""
    for i in myStr:
        if i == "a" or i =="b" or i =="c":
            if word != "":
                answer.append(word)
                word =""
        else:
            word += i
    if word != "":
        answer.append(word)
    if answer == []:
        answer = ["EMPTY"]
    return answer