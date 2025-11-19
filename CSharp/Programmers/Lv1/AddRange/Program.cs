class Program
{
    public long solution(int a, int b) 
    {
        long answer = 0;

        if (a < b)
        {
            answer = AddRange(a, b);
        }
        else if (a > b)
        {
            answer = AddRange(b, a);
        }
        else
        {
            answer = a;
        }
        
        return answer;
    }

    public long AddRange(int first, int second)
    {
        long answer = 0;
        for (int i = first; i < second + 1; i++)
        {
            answer += i;
        }

        return answer;
    }
    
    
    static void Main()
    {
        Program pg = new Program();
        Console.WriteLine(pg.solution(3, 5));
        Console.WriteLine(pg.solution(3, 3));
        Console.WriteLine(pg.solution(5, 3));
    }
}