"""
블록 이동하기(2020 KAKAO BLIND RECRUITMENT) - 2트
"""
def dfs(board, robot):
    n = len(board)
    while True:
        # 목적지에 도착하면 멈춘다.
        if (n - 1, n - 1) in robot:
            return board[n-1][n-1]


def solution(board):
    robot = [(0, 0), (0, 1)]
    # 시간은 -1 부터 시작하기
    board[0][0] = -1
    board[0][1] = -1
    return dfs(board, robot)


ex1 = [[0, 0, 0, 1, 1],[0, 0, 0, 1, 0],[0, 1, 0, 1, 1],[1, 1, 0, 0, 1],[0, 0, 0, 0, 0]]
print(solution(ex1))