# Hacker Rank : Roads and Libraries

### 🔗 링크
https://www.hackerrank.com/challenges/torque-and-development/problem

### 🧠 TIP
1. 노드 수 = n, 연결된 덩어리 수 = c면  
<b>최소 간선 수 = n - c</b>
2. 트리의 핵심 성질
: `“트리는 사이클이 없고 모든 노드가 연결된 그래프다. n개의 노드를 가진 트리는 항상 간선이 n - 1개다.”`  

### 🔍 그럼 언제 DFS, 언제 BFS?

✅ <b>BFS가 더 선호되는 경우</b>  
•	Queue 기반 반복 구현이라 스택오버플로 걱정 없음.  
•	C#, Java, Python 같은 언어에서 재귀 깊이에 제한이 있을 때 안정적.  
•	최단 거리 탐색이 필요한 경우 (BFS 특유의 레벨 탐색 덕분).

✅ <b>DFS가 편할 수 있는 경우</b>  
•	재귀로 짧고 간결하게 구현 가능.  
•	연결 요소 내에 도달 가능한 노드를 빠르게 쭉쭉 타고 들어갈 때 직관적.  
•	문제에서 “한 방향으로 끝까지 파고 들어가기”가 중요한 경우.