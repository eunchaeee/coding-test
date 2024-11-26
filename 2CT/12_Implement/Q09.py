"""
문자열 압축(https://school.programmers.co.kr/learn/courses/30/lessons/60057)
"""

def solution(s):
    # 압축 문자열의 최대 길이는 len(s)//2 이다.
    result = []
    # 압축 문자열 길이 별로 압축(1 ~ len(s)//2)
    for l in range(1, len(s) // 2 + 1):
        answer = ""
        idx = 0
        repeat_count = 1

        while idx < len(s):
            # 반복 문자열 저장
            repeat = s[idx:idx + l]
            # 반복 문자열이 다음 세트와 같을 경우
            if repeat == s[idx + l:idx + 2 * l]:
                # 인덱스는 반복문자열 길이만큼 증가
                idx += l
                # 반복 카운트 1 증가
                repeat_count += 1
                continue
            # 반복 문자열이 다음 세트와 다를 경우
            else:
                # 반복 횟수가 1보다 크면
                if repeat_count > 1:
                    # 이전까지의 압축 정보를 answer에 추가
                    answer += str(repeat_count)
                    answer += repeat
                    # print(idx, repeat, "*",answer)
                # 반복 횟수가 1보다 같거나 작으면
                else:
                    answer += s[idx:idx + l]
                    # print(repeat, "-", answer)
                idx += l
                repeat_count = 1
        result.append(len(answer))

    if len(result) == 0:
        return len(s)
    else:
        return min(result)

print(solution("aabbaccc"))
print(solution("ababcdcdababcdcd"))
print(solution("abcabcdede"))
print(solution("abcabcabcabcdededededede"))
print(solution("xababcdcdababcdcd"))