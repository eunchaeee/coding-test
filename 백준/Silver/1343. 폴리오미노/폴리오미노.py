board = input().rstrip()
answer = ''

for i in range(len(board)):
    if i < len(answer):
        continue
    if board[i] == '.':
        answer += '.'
    elif i+3 < len(board) and board[i:i+4] == 'XXXX':
        answer += 'AAAA'
    elif i+1 < len(board) and board[i:i+2] == 'XX':
        answer += 'BB'
    else:
        answer = -1
        break

print(answer)