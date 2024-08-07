using System;

public class Solution {
    public int solution(int a, int b) {
        int AB = a*Rank(b)+b;
        int BA = b*Rank(a)+a;
        return AB >= BA ? AB :BA;
    }
    public int Rank(int n){
        if(n==0)
            return 1;
        return 10*Rank(n/10);
    }
}