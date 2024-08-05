using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int sum =0;
        int index = 0;
        while(sum<=n){
            sum += numbers[index++];
        }
        return sum;
    }
}