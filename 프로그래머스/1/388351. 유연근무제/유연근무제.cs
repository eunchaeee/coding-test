using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        int num = schedules.Length;
        int limit = 0;
        bool isLate = false;
        int count = 0;
        
        for (int i = 0; i < num; i++)
        {
            isLate = false;
            limit = GetTimeLimit(schedules[i]);
            for (int day = 0; day < 7; day++)
            {
                // 주말 거르기
                if (startday == 7 && day == 6)
                {
                    continue;
                }
                else if (day == 6 - startday || day == 7 - startday)
                {
                    continue;
                }
                
                // 비교
                if (limit < timelogs[i,day])
                {
                    isLate = true;
                    break;
                }
            }

            if (!isLate) count++;
        }
        return count;
    }

    public int GetTimeLimit(int time)
    {
        int m = time % 100;
        int h = time / 100;
        if ((m + 10) >= 60)
        {
            h++;
            m = m + 10 - 60;
            return h * 100 + m;
        }
        return time + 10;
    }
}