# Hacker Rank : Two Characters

### 링크
https://www.hackerrank.com/challenges/two-characters/problem

### LINQ
```csharp
string filtered = new string(s.Where(c => c == a || c == b).ToArray());
```  

#### 1.	s.Where(c => c == a || c == b)
결과는 IEnumerable 형태
#### 2. .ToArray()
위에서 걸러진 문자를 char[] 배열로 변환
#### 3. new string(...)
char[] 배열을 다시 문자열로 바꿔줌