using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int max = 0 ;
        int past = 101 ;
        int[] result = new int[emergency.Length];
        for(int i = 1 ; i<result.Length+1;i++){
            max = 0;
            for(int j = 0 ; j<emergency.Length; j++){
                if(emergency[j]>max && emergency[j]<past){
                    result[j]=i;
                    max = emergency[j];
                }                
            }
            past = max;
        }
        return result;
    }
}