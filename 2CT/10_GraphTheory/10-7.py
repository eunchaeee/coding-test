"""
2. 팀 결성
"""
# 특정 원소가 속한 집합 찾기
def find_parent(parent, x):
    # 루트 노드가 아니라면, 루트 노드를 찾을 때까지 재귀적으로 호출
    if parent[x] != x:
        parent[x] = find_parent(parent, parent[x])
    return parent[x]

def union_parent(parent, a, b):
    a = find_parent(parent, a)  # a = a의 루트노드 (find_parent 에서 a의 루트가 최종 루트로 갱신됨)
    b = find_parent(parent, b)  # b = b의 루트노드 (find_parent 에서 b의 루트가 최종 루트로 갱신됨)
    # 루트(parent)끼리 합친다.
    if a < b:
        parent[b] = a
    else:
        parent[a] = b

# 학생 마지막 번호(n), 연산의 개수(m)
n, m = map(int, input().split())

# 부모 노드 리스트 초기화
parent = [0] * (n + 1)

# 부모 노드를 자기 자신으로 수정
for i in range(n + 1):
    parent[i] = i

for _ in range(m):
    op, a, b = map(int, input().split())
    if op == 0:
        union_parent(parent, a, b)
    elif op == 1:
        if find_parent(parent, a) == find_parent(parent, b):
            print("YES")
        else:
            print("NO")

'''
입력 예시
7 8
0 1 3
1 1 7
0 7 6
1 7 1
0 3 7
0 4 2
0 1 1
1 1 1
'''