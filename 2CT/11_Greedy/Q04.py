"""
04. 만들 수 없는 금액
화폐 단위를 기준으로 동전을 오름차순 정렬.
이후 1부터 차례대로 특정 금액을 만들 수 있는지 확인
(어려운데요.???)
"""
n = int(input())
coins = list(map(int, input().split()))
coins.sort()

target = 1
for x in coins:
    # 만들 수 없는 금액을 찾았을 때 반복 종료
    if target < x:
        break
    target += x

# 만들 수 없는 금액 출력
print(target)