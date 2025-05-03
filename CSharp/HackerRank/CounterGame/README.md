# Hacker Rank : Counter Game

링크
https://www.hackerrank.com/challenges/counter-game

## 개선 포인트
### 1. 성능 향상을 위한 비트 연산 고려 가능

n이 2의 거듭제곱인지 체크할 때:  
`(n & (n - 1)) == 0`  
위 연산이 true이면 n은 2의 거듭제곱임 (더 빠름)

### 2. 2의 거듭제곱에 관한 문제는 한번 쯤은 비트 연산을 떠올리자!