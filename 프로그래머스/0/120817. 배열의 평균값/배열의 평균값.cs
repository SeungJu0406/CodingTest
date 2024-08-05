using System;

public class Solution {
    public double solution(int[] numbers) {
        int sum =0;
        for(int i =0;i<numbers.Length;i++){
            sum +=numbers[i];
        }
        return (double)sum/(double)numbers.Length;
    }
}