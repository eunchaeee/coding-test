"""
04. 만들 수 없는 금액
C1, C2, .. , Ck 까지 동전이 있을 때 1 ~ C1+C2+...+CK 까지 금액을 다 만들 수 있다고 치자.
TOTAL(k) = C1 + C2 + ... + Ck 라고 하면
위의 상황에서 만들 수 없는 금액의 최솟값은 TOTAL(k) + 1.
어떤 CK+1 이 오면 저 규칙이 깨질까?
Ck+1 의 범위가 TOTAL(K) + 1 까지 일때는 만들 수 없는 금액의 최솟값이 TOTAL(K) + 2
그러나 Ck+1 의 범위가 TOTAL(k) + 2 부터는 TOTAL(k) + 1 이 만들 수 없는 금액의 최솟값
"""
def solution(coins):
    coins.sort()
    total = 0
    for c in coins:
        if total + 1 < c:
            return total + 1
        else:
            total += c
    return total + 1

n = int(input())
coins = list(map(int, input().split()))
print(solution(coins))