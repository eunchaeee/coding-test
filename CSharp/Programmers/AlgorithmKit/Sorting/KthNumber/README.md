# 프로그래머스 코딩테스트 고득점 Kit
# [정렬] K번째 수

## 링크
https://school.programmers.co.kr/learn/courses/30/lessons/42748

## 걸린 시간
21분

## 포인트
LINQ Skip()과 Take 의 사용법

```csharp
using Linq
    
    int[] picked = array.Skip(startIdx).Take(endIdx - startIdx + 1).ToArray();
```

