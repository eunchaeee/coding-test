def solution(mats, park):
    row = len(park)
    col = len(park[0])
    max_length = 0

    for i in range(row - 1, -1, -1):
        for j in range(col - 1, -1, -1):
            if park[i][j] == "-1":
                # right, below, right_below 값 확인
                # park[i][j] = 가장 작은값 + 1
                park[i][j] = min(check(i, j + 1, park),
                                 check(i+1, j, park),
                                 check(i+1, j+1, park)) + 1

                if park[i][j] > max_length:
                    max_length = park[i][j]

    mats.sort(reverse=True)
    for i in mats:
        if i <= max_length:
            return i
    return -1

def check(i, j, park):
    row = len(park)
    col = len(park[0])
    if i >= row or i < 0 or j >= col or j < 0:
        return 0
    if isinstance(park[i][j], str) and park[i][j].isalpha():
        return 0
    return park[i][j]