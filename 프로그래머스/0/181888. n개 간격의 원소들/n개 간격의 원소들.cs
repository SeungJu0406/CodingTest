using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] result = new int[num_list.Length%n==0? num_list.Length/n : num_list.Length/n+1];
        for(int i = 0 ; i < result.Length; i++){
            result[i] = num_list[i*n];
        }
        return result;
    }
}