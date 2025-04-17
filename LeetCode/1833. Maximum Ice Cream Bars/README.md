# LeetCode 1883. Maximum Ice Cream Bars

## 🔗 문제링크
https://leetcode.com/problems/maximum-ice-cream-bars/description/

##  내 풀이 요약

```
1. max(costs) 기반 counts 배열 만들기
2. 각 가격 개수 세기
3. 누적합 (prefix sum) 만들기
4. 안정 정렬 방식으로 sorted_costs 만들기
5. 앞에서부터 coins 까먹으며 개수 세기
```

## 개선점


<b>누적합 만들 때 range 범위 명확하게</b>
```python
for i in range(1, len(counts)):
    counts[i] += counts[i - 1]
```

→ 이게 더 일반적인 prefix sum 패턴이야!

## 시간 복잡도 정리
👉 총합:
`O(n + k)`  

📌 왜 이렇게 나오는지 설명!

| 단계 | 내용                                      | 시간 복잡도 |
|------|-------------------------------------------|--------------|
| 1    | 최댓값 찾기 (`max(costs)`)                | O(n)         |
| 2    | counts 배열 만들기                         | O(k)         |
| 3    | 각 가격 개수 세기                          | O(n)         |
| 4    | 누적합 만들기                              | O(k)         |
| 5    | 정렬된 배열 만들기                         | O(n)         |
| 6    | 정렬된 배열에서 최대한 구매                | O(n)         |
|      | **총합**                                   | **O(n + k)** |

→ 반복문이 각각 n 또는 k 길이만큼만 도니까 전부 합쳐도 `O(n + k)`


### ❗ 주의할 점
<b>Counting Sort는 k가 너무 크면 비효율적일 수 있음!</b>  
예: costs = [1, 100000000] 처럼 큰 숫자가 있을 때는
메모리도 O(k) 쓰고, 속도도 느려질 수 있어 😵

## 공간 복잡도
```
counts 배열: O(k)

sorted_costs 배열: O(n)
```
→ 전체 공간 복잡도: O(n + k)

## 🔥 결론

항목	복잡도
시간 복잡도	O(n + k)
공간 복잡도	O(n + k)
단, k가 작을 때만 효율적!	