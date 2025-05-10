def solution(n, k, cmd):
    answer = ['O'] * n
    # set the datas
    data = { i : [i-1, i+1] for i in range(n)}

    select = k
    deleted = []
    # do the operations
    for c in cmd:
        part = c.split()
        op = part[0]
        if op == "D":
            for _ in range(int(part[1])):
                select = data[select][1]
        elif op == "U":
            for _ in range(int(part[1])):
                select = data[select][0]
        elif op == "C":
            prev, next = data[select]
            deleted.append((select, prev, next))
            answer[select] = "X"

            # 재연결
            if prev != -1:
                data[prev][1] = next
            if next != len(data):
                data[next][0] = prev

            select = next if next != len(data) else prev
        elif op == "Z":
            (idx, prev, next) = deleted.pop()
            data[idx] = [prev, next]
            answer[idx] = "O"

            if prev != -1:
                data[prev][1] = idx
            if next != n:
                data[next][0] = idx
    return ''.join(answer)