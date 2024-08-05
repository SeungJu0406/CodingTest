using System;

public class Solution {
    public long solution(int balls, int share) {
        long result = 1L;
        int count = 1;
        for(int i = 0 ; i<share;i++){
            result *= balls--;
            result /= count++;
        }
        return result;
    }
}