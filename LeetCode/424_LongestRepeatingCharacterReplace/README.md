# LeetCode 424. Longest Repeating Character Replace

## 링크
https://leetcode.com/problems/longest-repeating-character-replacement/description/

## 풀이
시작점(i가 0이거나, s[i] != s[i-1] 일 때)에 다다랐을 때, Count 함수를 실행시킨다.  
순방향으로 반복되는 개수를 세고, k가 남았을 때, 역방향으로 추가한다.

이를 각 알파벳 대문자가 Key인 해시맵에 저장하고, 그 중 Value가 Max인 것을 뽑는다.


## 질문
- 시간복잡도 어떻게 빠르게 풀지?(806ms 나옴)