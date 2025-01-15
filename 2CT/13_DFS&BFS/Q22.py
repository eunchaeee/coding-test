"""
블록 이동하기(2020 KAKAO BLIND RECRUITMENT)
"""

def dfs(board, robot):
    # 상하좌우로 움직일 수 있는 방향들
    dir = [[(0, -1), (0, -1)], [(0, 1), (0, 1)], [(-1, 0), (-1, 0)], [(1, 0), (1, 0)]]

    n = len(board)
    time = 0

    while True:
        # 목적지에 도착하면 멈춘다.
        if (n - 1, n - 1) in robot:
            return board[n-1][n-1]
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
            new_r = board[dlx][dly] + 1
            new_l = board[drx][dry] + 1
            time += 1
            if board[nlx][nly] == 0 or board[nlx][nly] > new_l:
                board[nlx][nly] = new_l
            if board[nrx][nry] == 0 or board[nrx][nry] > new_r:
                board[nrx][nry] = new_r
            return dfs(board, [(nlx, nly), (nrx, nry)])

        # 회전
        # x 자리가 같을 때 : 가로 본능
        if  robot[0][0] == robot[1][0]:
            new_robot =  [[robot[0], (robot[0][0] - 1, robot[0][1])], [robot[0], (robot[0][0] +  1, robot[0][1])], [robot[1], (robot[1][0] - 1, robot[1][1])], [robot[1], (robot[1][0] + 1, robot[1][1])]]

def solution(board):
    robot = [(0, 0), (0, 1)]
    # 시간은 -1 부터 시작하기
    board[0][0] = -1
    board[0][1] = -1
    return dfs(board, robot)


ex1 = [[0, 0, 0, 1, 1],[0, 0, 0, 1, 0],[0, 1, 0, 1, 1],[1, 1, 0, 0, 1],[0, 0, 0, 0, 0]]
print(solution(ex1))