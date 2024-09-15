using System;


public class Solution {
    public long solution(long n) {
        double sqrt = Math.Sqrt(n);
        if(Math.Floor(sqrt) != sqrt)
            return -1;
        return (long)Math.Pow(sqrt+1,2);
        
    }
}