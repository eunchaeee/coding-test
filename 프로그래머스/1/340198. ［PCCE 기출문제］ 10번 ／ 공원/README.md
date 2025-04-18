# [level 1] [PCCE 기출문제] 10번 / 공원 - 340198 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/340198) 
### 회고(코드 개선점)
#### 1. 매개변수로 들어온 값은 건들지 않는게 좋다.
- park를 그대로 덮어쓰기보다는 dp 라는 변수를 하나 만들어서 사용하는게 나음.  

#### 2. check 함수 효율성 개선
- 매번 check 하기보다는 park[i][j] 값이 알파벳이 나왔을 때 dp[i][j] = 0 을 넣고 앞에서 범위 체크 정도만 해주는 게 효율이 훨씬 좋음.

#### 3. dp 를 더 깔끔하게 사용하는 팁
- 각 행렬의 가장자리 부분의 값을 미리 구한 뒤 dp를 돌린다.
- 가장 자리에 라인을 하나 만들어서 다 0으로 넣고 dp 돌리기를 시작한다.


### 성능 요약

메모리: 9.23 MB, 시간: 3.85 ms

### 구분

코딩테스트 연습 > PCCE 기출문제

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 04월 17일 23:13:06

### 문제 설명

<p>지민이는 다양한 크기의 정사각형 모양 돗자리를 가지고 공원에 소풍을 나왔습니다. 공원에는 이미 돗자리를 깔고 여가를 즐기는 사람들이 많아 지민이가 깔 수 있는 가장 큰 돗자리가 어떤 건지 확인하려 합니다. 예를 들어 지민이가 가지고 있는 돗자리의 한 변 길이가 5, 3, 2 세 종류이고, 사람들이 다음과 같이 앉아 있다면 지민이가 깔 수 있는 가장 큰 돗자리는 3x3 크기입니다.</p>

<p><img src="https://grepp-programmers.s3.ap-northeast-2.amazonaws.com/files/production/b303f9e8-1d3e-4e44-a75e-e8deb64c8e6c/10.jpg" title="" alt="10.jpg"></p>

<p>지민이가 가진 돗자리들의 한 변의 길이들이 담긴 정수 리스트 <code>mats</code>, 현재 공원의 자리 배치도를 의미하는 2차원 문자열 리스트 <code>park</code>가 주어질 때 지민이가 깔 수 있는 가장 큰 돗자리의 한 변 길이를 return 하도록 solution 함수를 완성해 주세요. 아무런 돗자리도 깔 수 없는 경우 -1을 return합니다.</p>

<hr>

<h4>제한사항</h4>

<ul>
<li>1 ≤ <code>mats</code>의 길이 ≤ 10

<ul>
<li>1 ≤ <code>mats</code>의 원소 ≤ 20</li>
<li><code>mats</code>는 중복된 원소를 가지지 않습니다.</li>
</ul></li>
<li>1 ≤ <code>park</code>의 길이 ≤ 50

<ul>
<li>1 ≤ <code>park[i]</code>의 길이 ≤ 50</li>
<li><code>park[i][j]</code>의 원소는 문자열입니다.</li>
<li><code>park[i][j]</code>에 돗자리를 깐 사람이 없다면 "-1", 사람이 있다면 알파벳 한 글자로 된 값을 갖습니다.</li>
</ul></li>
</ul>

<hr>

<h4>입출력 예</h4>
<table class="table">
        <thead><tr>
<th>mats</th>
<th>park</th>
<th>result</th>
</tr>
</thead>
        <tbody><tr>
<td>[5,3,2]</td>
<td>[["A", "A", "-1", "B", "B", "B", "B", "-1"], ["A", "A", "-1", "B", "B", "B", "B", "-1"], ["-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1"], ["D", "D", "-1", "-1", "-1", "-1", "E", "-1"], ["D", "D", "-1", "-1", "-1", "-1", "-1", "F"], ["D", "D", "-1", "-1", "-1", "-1", "E", "-1"]]</td>
<td>3</td>
</tr>
</tbody>
      </table>
<hr>

<h4>입출력 예 설명</h4>

<p>입출력 예 #1</p>

<ul>
<li>지문과 동일합니다.</li>
</ul>

<hr>

<ul>
<li>cpp를 응시하는 경우 리스트는 배열과 동일한 의미이니 풀이에 참고해주세요.

<ul>
<li>ex) 번호가 담긴 정수 <u><strong>리스트</strong></u> <code>numbers</code>가 주어집니다. =&gt; 번호가 담긴 정수 <u><strong>배열</strong></u> <code>numbers</code>가 주어집니다.</li>
</ul></li>
<li>java를 응시하는 경우 리스트는 배열, 함수는 메소드와 동일한 의미이니 풀이에 참고해주세요.

<ul>
<li>ex) solution <u><strong>함수</strong></u>가 올바르게 작동하도록 한 줄을 수정해 주세요. =&gt; solution <u><strong>메소드</strong></u>가 올바르게 작동하도록 한 줄을 수정해 주세요.</li>
</ul></li>
</ul>


> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges