"""
자물쇠와 열쇠
"""
import copy

def solution(key, lock):

    print(open(key, lock))
    copy_key = key.copy()

    for i in range(3):
        copy_key = rotate_clockwise(copy_key)
        print(open(copy_key, lock))

    return

    '''
    문제가 생김!! 다음의 로직은 오른쪽 -> 아래 이동의 경우의 수가 포함되어 있지 않음!!!!!!
    '''
    # 000 추가하는 경우의 수 : 위 2개, 아래 2개, 오른쪽 2개, 왼쪽 2개
    # 각각 4번 회전 가능 => 8 * 4 = 32 회 검사
    # 이때 key 돌기 개수가 lock 구멍 개수보다 작으면 다음으로 continue
    # 모든 합이 1인 짝이 나오면 return True 나머지는 return False
    # key 돌기 개수가 lock 구멍 개수보다 작을 때 return False
    print(key)
    print('up', move(key, 'up'))
    print('down', move(key, 'down'))
    print('left', move(key, 'left'))
    print('right', move(key, 'right'))
    copy_key = key.copy()

    lock_hole_count = element_count(lock, 0)
    for i in range(len(key) - 1):
        copy_key = move(copy_key, 'up')
        if element_count(copy_key, 1) < lock_hole_count:
            continue
    answer = True
    #print(rotate_clockwise(key))
    return answer

def open(key, lock):
    for i in range(len(key)):
        for j in range(len(key[0])):
            if key[i][j] + lock[i][j] != 1:
                return False
    return True

def move(key, side):
    result = []
    if side == 'up':
        result = [[0 for _ in range(len(key[0]))]]
        return result + key[0:len(key)-1]
    elif side == 'down':
        result = [[0 for _ in range(len(key[0]))]]
        return key[1:] + result
    elif side == 'left':
        for row in key:
            result.append([0] + row[0:len(row)-1])
        return result
    elif side == 'right':
        for row in key:
            result.append(row[1:] + [0])
        return result




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