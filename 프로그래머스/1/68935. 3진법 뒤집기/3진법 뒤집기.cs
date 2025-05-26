using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n)
    {
        int answer = 0;
        List<int> baseThree = new List<int>();

        while (n > 0)
        {
            int remain = n % 3; 
            baseThree.Add(remain);
            n /= 3;
        }

        baseThree.Reverse();

        for(int i = 0; i < baseThree.Count; i++)
        {
            answer += baseThree[i] * Pow(3, i);
        }

        return answer;
    }

    public int Pow(int n, int p)
    {
        int answer = 1; 
        for(int i = 0; i < p; i++)
        {
            answer *= n;
        }
        return answer;
    }
}