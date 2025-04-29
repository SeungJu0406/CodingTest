using System;
using System.Collections.Generic;

public class Solution {
    private HashSet<int> sums = new HashSet<int>();
    public int solution(int[] elements)
    {
        sums.Clear();
        for (int i = 0; i < elements.Length; i++) // 모든 원소들 하나씩 
        {
            int elementSum = 0;
            for (int j = 0; j < elements.Length; j++) // 원소 하나당 길이수 하나하나만큼 
            {
                elementSum += elements[(i+j) % elements.Length];
                sums.Add(elementSum);
            }
        }
        return sums.Count;
    }
}