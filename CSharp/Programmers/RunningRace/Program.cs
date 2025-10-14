using System;
using System.Diagnostics;

public class Solution 
{
    public string[] solution(string[] players, string[] callings)
    {
        // 랭크 정보 저장
        Dictionary<string, int> rank = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {
            rank[players[i]] = i;
        }
        
        for (int i = 0; i < callings.Length; i++)
        {
            // 불린 사람 등수
            int cur = rank[callings[i]];
            
            // 앞사람
            string front = players[cur - 1];
            players[cur - 1] = callings[i];
            players[cur] = front;
            
            rank[callings[i]] -= 1;
            rank[front] += 1;
        }

        string[] answer = new string[players.Length];

        foreach (KeyValuePair<string, int> pair in rank)
        {
            answer[pair.Value] = pair.Key;
        }
        
        return answer;
    }
    
    public static void Main()
    {
        var sol = new Solution();
        sol.solution(["mumu", "soe", "poe", "kai", "mine"], ["kai", "kai", "mine", "mine"]);
    }
}

