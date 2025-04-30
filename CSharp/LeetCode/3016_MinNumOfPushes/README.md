# LeetCode 3016 - Minimum Number of Pushes to Type Word II

🔗 https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-ii/description/
## 풀이 아이디어
- 알파벳 빈도 수를 세고, 점수 그룹(1~4점)에 따라 점수를 합산.
- 내림차순 정렬 후, 그룹당 점수를 곱해서 합산.

## ⏱️ 시간복잡도

| 단계 | 복잡도 |
|------|--------|
| 알파벳 빈도 계산 | O(n) |
| 정렬 (고정 크기 26) | O(1) |
| 점수 계산 (26개 순회) | O(1) |
| **총합** | **O(n)** |

- `n`: 입력 문자열의 길이
- 정렬은 26개 고정이므로 상수 시간으로 간주 가능

## 📦 공간복잡도

- `int[] count = new int[26]` → **O(1)** (고정 크기 배열)