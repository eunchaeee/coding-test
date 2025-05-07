# 프로그래머스 코딩테스트 고득점 Kit
# [완전탐색] 1. 최소 직사각형

## 링크
https://school.programmers.co.kr/learn/courses/30/lessons/86491

## 학습 포인트 : C# 2차원 배열

### 1. 초기화 방법


```csharp
int[,] sizes = new int[,] { 
    { 60, 50 }, 
    { 30, 70 }, 
    { 60, 30 }, 
    { 80, 40 } 
};
```


### 2. 접근
C#에서 `int[,]`은 진짜 딱딱한 다차원 배열이라서
한 줄 통째로 `[60, 50]`처럼 한 번에 튜플이나 배열로 가져오는 건 안 돼.

### 3. Length
```csharp
sizes.Length = 8    // 전체 요소 수를 출력함
sizes.GetLength(0) = 4    // 행의 수를 출력함
sizes.GetLength(1) = 2    // 열의 수를 출력함
```