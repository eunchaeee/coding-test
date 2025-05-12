# LeetCode 932. Beautiful Array

## 링크
https://leetcode.com/problems/beautiful-array/description/

## 풀이 아이디어

어떤 아름다운 배열 X가 있을 때, 그 배열의 앞부분이 A, 뒷 부분이 B로 나눠진다고 하자.  
A가 홀수로만 이루어진 아름다운 배열이고,
B가 짝수로만 이루어진 아름다운 배열이라면  
A+B, 즉 X는 아름다운 배열이 된다.  
A의 임의의 원소 a(홀수)와 B의 임의의 원소 b(짝수)를 더해서 2로 나누면 소수가 되기 때문에  
`nums[k] == nums[i] + nums[j]` 를 만족할 수 없기 때문이다.

#### (Divide and Conquer)