"""
외벽 점검
"""

def solution(n, weak, dist):
    answer = 0
    weak_count = len(weak)
    c = []

    if weak_count == 1:
        answer = 1
    elif weak_count == 2:
        coverage = min(weak[1] - weak[0], n - (weak[1] - weak[0]))
        for i in dist:
            if i >= coverage:
                return 1
            else:
                if len(dist) >= 2:
                    return 2
                else:
                    return -1
    else:
        for i in range(weak_count):
            if i == weak_count - 1:
                c.append(weak[i] - weak[0])
            c.append(weak[i+1] - weak[i])
    return answer


print(solution(12, [1, 5, 6, 10], [1, 2, 3, 4]))
print(solution(12, [1, 3, 4, 9, 10], [3, 5, 7]))