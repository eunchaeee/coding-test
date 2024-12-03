"""
자물쇠와 열쇠
"""
def solution(key, lock):
    # 자물쇠 확장
    m = len(key)
    n = len(lock)

    board = [[0] * (n + 2*m) for _ in range(n + 2*m)]
    for i in range(n):
        for j in range(n):
            board[m + i][m + j] = lock[i][j]

    # 열어보기
    for i in range(n+m):
        for j in range(n+m):
            if compare(key, board, i, j):
                return True

    for _ in range(3):
        key = rotate(key)
        for i in range(n + m):
            for j in range(n + m):
                if compare(key, board, i, j):
                    return True

    return False

def compare(key, board, i, j):
    m = len(key)
    n = len(board) - 2 * m
    result = True
    for x in range(m):
        for y in range(m):
            board[i+x][j+y] += key[x][y]

    for x in range(n):
        for y in range(n):
            if board[m + x][m + y] != 1:
                result = False

    for x in range(m):
        for y in range(m):
            board[x+i][y+j] -= key[x][y]

    return result

def rotate(key):
    m = len(key)
    result = [[] for _ in range(m)]

    for i in range(m-1, -1, -1):
        for j in range(m):
            result[j].append(key[i][j])
    return result


print(solution([[0, 0, 0], [1, 0, 0], [0, 1, 1]], [[1, 1, 1], [1, 1, 0], [1, 0, 1]]))