using System;

public class Solution 
{
    public int[] solution(string[] operations) 
    {
        int[] answer = new int[] {};
        var minHeap = new PriorityQueue<int, int>();
        var maxHeap = new PriorityQueue<int, int>();
        var map = new Dictionary<int, int>();
        
        foreach (var op in operations)
        {
            var parts = op.Split();
            string command = parts[0];
            int num = int.Parse(parts[1]);
            
            if (command == "I")
            {
                minHeap.Enqueue(num,num);
                maxHeap.Enqueue(num,-num);
                if (!map.ContainsKey(num)) map[num] = 0;
                map[num]++;
            }
            else if (command == "D")
            {
                if (map.Count == 0) continue;

                if (num == 1) RemoveValid(maxHeap, map);
                else if (num == -1) RemoveValid(minHeap, map);
            }
        }

        int? max = GetValid(maxHeap, map);
        int? min = GetValid(minHeap, map);

        if (map.Count == 0) return new int[] { 0, 0 };
        else return new int[] {max.Value, min.Value};
    }

    private void RemoveValid(PriorityQueue<int, int> heap, Dictionary<int, int> map)
    {
        // 힙이 빌때까지(맵이 그 값을 가지고 있지 않다면 다시 Dequeue 해야 하기 때문!)
        while (heap.Count > 0)
        {
            // 가장 우선순위 값을 꺼낸다.
            int val = heap.Dequeue();
            
            // 맵이 그 값을 가지고 있지 않다면 다시 돌린다.
            if (!map.ContainsKey(val)) 
                continue;

            // 맵이 그 값을 가지고 있다면 개수 하나 빼준다.
            map[val]--;
            // 그 값의 개수가 0이라면
            if (map[val] == 0)
            {
                // 그 값을 맵에서 아예 뺀다.
                map.Remove(val);
            }
            // while 문 탈출
            break;
        } 
    }

    int? GetValid(PriorityQueue<int, int> heap, Dictionary<int, int> map)
    {
        while (heap.Count > 0)
        {
            int val = heap.Dequeue();
            if (map.ContainsKey(val))
            {
                heap.Enqueue(val, val);
                return val;
            }
        }

        return null;
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        Console.WriteLine(string.Join(" ", sol.solution(["I 16", "I -5643", "D -1", "D 1", "D 1", "I 123", "D -1"])));
        Console.WriteLine(string.Join(" ", sol.solution(["I -45", "I 653", "D 1", "I -642", "I 45", "I 97", "D 1", "D -1", "I 333"])));
    }
}