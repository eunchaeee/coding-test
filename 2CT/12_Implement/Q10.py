"""
자물쇠와 열쇠
"""

def solution(key, lock):
    # 000 추가하는 경우의 수 : 위 2개, 아래 2개, 오른쪽 2개, 왼쪽 2개
    # 각각 4번 회전 가능 => 8 * 4 = 32 회 검사
    # 이때 key 돌기 개수가 lock 구멍 개수보다 작으면 다음으로 continue
    # 모든 합이 1인 짝이 나오면 return True 나머지는 return False
    # key 돌기 개수가 lock 구멍 개수보다 작을 때 return False
    answer = True
    print(rotate_clockwise(key))
    return answer


def rotate_clockwise(key):
    m = len(key)
    result = [[] for _ in range(m)]

    for i in range(m-1, -1, -1):
        for j in range(m):
            result[j].append(key[i][j])
    return result

def element_count(mat, element):
    result = 0
    for i in range(len(mat)):
        for j in range(len(mat[0])):
            if mat[i][j] == element:
                result += 1
    return result


solution([[0, 0, 0], [1, 0, 0], [0, 1, 1]], [[1, 1, 1], [1, 1, 0], [1, 0, 1]])