"""
블록 이동하기(2020 KAKAO BLIND RECRUITMENT)
"""

def solution(board):
    robot = [(0, 0), (0, 1)]
    # 시간은 -1 부터 시작하기
    board[0][0] = -1
    board[0][1] = -1
    n = len(board)
    time = 0
    dir = [[(0, -1), (0, -1)], [(0, 1), (0, 1)], [(-1, 0), (-1, 0)], [(1, 0), (1, 0)]]
    while True:
        if (n - 1, n - 1) in robot:
            break
        # 이동
        for [(dlx, dly), (drx, dry)] in dir:
            nlx = robot[0][0] + dlx
            nly = robot[0][1] + dly
            nrx = robot[1][0] + drx
            nry = robot[1][1] + dry
            robot_new = [(nlx, nly), (nrx, nry)]
            if nlx < 0 or nlx >= n or nly < 0 or nly >= n or nrx < 0 or nrx >= n or nry < 0 or nry >= n:
                continue
            elif board[nlx][nly] == 1 or board[nrx][nry] == 1:
                continue
            # 이동이 가능할 때

        # 회전
    answer = 0
    return answer


ex1 = [[0, 0, 0, 1, 1],[0, 0, 0, 1, 0],[0, 1, 0, 1, 1],[1, 1, 0, 0, 1],[0, 0, 0, 0, 0]]
print(solution(ex1))