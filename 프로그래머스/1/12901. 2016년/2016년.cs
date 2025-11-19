public class Solution {
    public string solution(int a, int b) {
        string answer = "";

        string[] day = new[] { "THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
        int[] month_day = new[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };        
        
        int day_count = 0;

        for (int i = 0; i < a; i++)
        {
            day_count += month_day[i];
        }

        day_count += b;
        day_count %= 7;
        
        return day[day_count];
    }
}