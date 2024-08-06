using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] result = new int[num_list.Length];
        for(int i = n ; i<num_list.Length ; i++){
            result[i-n]=num_list[i];
        }
        for(int i = 0; i < n ; i++){
            result[i+(num_list.Length-n)]=num_list[i];
        }
        return result;
    }
}