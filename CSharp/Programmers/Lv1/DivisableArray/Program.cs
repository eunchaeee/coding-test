class Program
{    
    public static int[] solution(int[] arr, int divisor) 
    {
        List<int> answer = new List<int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                answer.Add(arr[i]);
            }    
        }

        if (answer.Count == 0)
        {
            answer.Add(-1);
        }
        
        answer.Sort();
        return answer.ToArray();
    }
    
    static void Main()
    {
        int[] arr1 = new int[4] {5, 9, 7, 10};
        int[] arr2 = new int[4] { 2, 36, 1, 3 };
        int[] arr3 = new int[3] { 3, 2, 6 };
        Console.WriteLine(solution(arr1, 5));
        Console.WriteLine(solution(arr2, 1));
        Console.WriteLine(solution(arr3, 10));
    }
}