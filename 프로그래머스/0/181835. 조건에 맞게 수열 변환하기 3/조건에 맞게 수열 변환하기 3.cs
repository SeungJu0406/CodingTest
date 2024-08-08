using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        for(int i = 0 ; i<arr.Length ; i++){
            if(k%2!=0)
                arr[i] *= k;
            else
                arr[i] +=k;
        }
        return arr;
    }
}