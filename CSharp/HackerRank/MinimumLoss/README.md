# Hacker Rank : Minimum Loss

링크 : https://www.hackerrank.com/challenges/minimum-loss/problem

## 문제풀이
- 처음에는 완전탐색(브루트포스)로 풀어봄 => 시간초과 `O(n제곱)`
- 수정 아이디어 : 로스가 적으려면 값 정렬하고 이웃한 것끼리 빼면 된다.
- 인덱스 순서를 빠르게 보기 위해, 해시맵을 만들고`O(n)` 정렬한다.`O(nlogn)`
- 해시맵 값 접근 시간복잡도는 O(1)이다.
- 예외 : 같은 Value값을 여러개의 키가 동시에 가질 경우 `최대 O(n)`

#### 해시맵은 공간복잡도를 조금 쓰고, 시간복잡도를 줄일 수 있다!