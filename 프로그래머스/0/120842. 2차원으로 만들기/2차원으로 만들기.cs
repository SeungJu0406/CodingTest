using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] result = new int[num_list.Length/n,n];
        int count = 0;
        for(int y = 0 ; y < result.GetLength(0);y++){
            for(int x= 0; x<result.GetLength(1);x++){
                result[y,x]=num_list[count];
                count++;
            }
        }
        return result;
    }
}