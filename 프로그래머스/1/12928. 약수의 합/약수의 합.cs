using System;

public class Solution {
    public int solution(int n) {
        int result = 0;
        double range = Math.Sqrt(n);
        for(int i = 1 ;(double) i <= range ; i++){
            if(n%i == 0){
                result += i;
                if(i != n/i)
                {
                   result += n/i;
                }
            }
        }
        return result;
    }
}