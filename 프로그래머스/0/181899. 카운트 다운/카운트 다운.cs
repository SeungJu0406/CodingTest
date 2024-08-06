using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start, int end) {
        List<int> result = new List<int>(start-end+1);
        for(int i = start ; i>=end ; i--){
            result.Add(i);
        }
        return result.ToArray();
    }  
}