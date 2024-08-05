using System;

public class Solution {
    public int solution(int n) {
        int m = n;
        while(m%6!=0){
            m+=n;
        }
        return m/6;        
    }

    
}