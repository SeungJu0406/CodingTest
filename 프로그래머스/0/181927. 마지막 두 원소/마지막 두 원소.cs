using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] result = new int[num_list.Length+1];
        for(int i = 0 ; i < num_list.Length; i++){
            result[i] = num_list[i];
        }        
        int past = result[result.Length-2];
        int morePast = result[result.Length-3];
        result[result.Length-1]= past>morePast? past-morePast : past *2;
        return result;
    }
}