using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int temp = 0;
        for(int i = 0; i<num_list.Length/2;i++){
            temp = num_list[i];
            num_list[i]=num_list[num_list.Length-1-i];
            num_list[num_list.Length-1-i]=temp;
        }
        return num_list;
    }
}