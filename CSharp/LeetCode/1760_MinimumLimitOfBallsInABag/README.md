# [LeetCode] 1760. Minimum Limit of Balls in a Bag

## 링크
https://leetcode.com/problems/minimum-limit-of-balls-in-a-bag/description/

## 이진탐색(Binary Search)

정렬된 배열에서 어떤 값을 빠르게 찾는 알고리즘.  
탐색 범위를 계속 절반씩 줄여가면서 값을 찾아!


## 🔨 핵심 개념
우리가 찾고자 하는 범위가 [left, right]일 때,  
중간값 mid = (left + right) / 2를 기준으로:  
- 찾는 값이 mid보다 작으면, right = mid - 1  
- 찾는 값이 mid보다 크면, left = mid + 1  
- 같으면 찾은 거야!

그래서 시간복잡도는 O(log N)! 아주 빠름!


## 반올림 트릭
### 올림을 내림으로 바꾸는 트릭
total가 전체 케이크양, 한 조각에 x 크기를 넘지 않도록 자르려고 한다면,  
원래는 ((float)total / x) 을 올림한 값에서 - 1 번의 칼질을 해야함.  
이걸 (total + (x - 1)) / x  의 내림 값에서 -1 한걸로 변형.  
결국 (total - 1) / x 에 + 1 에 - 1을 한 값이 됨.  
정리하면 (total - 1) / x


```csharp

    operations += (total - 1) / x;  // total을 x 이하로 분할하는데 필요한 횟수 

```


