# 프로그래머스 코딩테스트 고득점 Kit
# [정렬] 가장 큰 수

## 링크
https://school.programmers.co.kr/learn/courses/30/lessons/42746


## 기억하기

그냥 코드 자체를 외우는 게 좋을듯!

```csharp
using System.Linq;

    public string solution(int[] numbers)
    {
        // 숫자를 문자열로 변환
        string[] strNums = numbers.Select(n => n.ToString()).ToArray();

        // 커스텀 정렬: 두 수를 이어붙인 결과 중 큰 순서대로 정렬
        Array.Sort(strNums, (a, b) => (b + a).CompareTo(a + b));

        // 모든 숫자를 이어붙인 후, "000..." 방지 위해 int → string
        string result = string.Join("", strNums);
        if (result[0] == '0') return "0";  // 예: [0, 0, 0] 같은 경우

        return result;
    }
```