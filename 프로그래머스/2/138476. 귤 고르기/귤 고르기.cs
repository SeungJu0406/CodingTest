using System;
using System.Collections.Generic;

public class Solution {
    private List<int> _counts = new List<int>();
    public int solution(int k, int[] tangerine)
    {
        _counts.Clear();

        Array.Sort(tangerine); // 크기별로 정렬

        int count = 0;
        for (int i = 1; i < tangerine.Length; i++)
        {
            count++;
            if (tangerine[i] != tangerine[i - 1])
            {
                _counts.Add(count);
                count = 0;
            }
        }
        _counts.Add(++count);
        _counts.Sort();
        _counts.Reverse();

        int answer = 0;
        int curCount = 0;
        for (int i = 0; i < _counts.Count; i++)
        {
            if (curCount < k)
            {
                curCount += _counts[i];
                answer++;
            }
            else
            {
                break;
            }
        }
        return answer;
    }
}