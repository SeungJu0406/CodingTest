using System;

public class Solution {
    public int[] solution(int n, int k) {
        int[] result = new int[n/k];
        int index =0;
        for(int i = k ; i<=n ; i += k ){
            result[index++]=i;
        }
        return result;
    }
}