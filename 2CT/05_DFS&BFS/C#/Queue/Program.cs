using System;
using System.Collections.Generic;

public class Queue
{
    public static void Main()
    {
        Queue<int> queue = new Queue<int>();
        
        // Enqueue: 데이터 추가
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        
        // Peek: 맨 앞 확인 (꺼내지 않음)
        Console.WriteLine(queue.Peek());
        
        // Dequeue: 맨 앞 꺼내기
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        
        Console.WriteLine(queue.Count);
    }
}