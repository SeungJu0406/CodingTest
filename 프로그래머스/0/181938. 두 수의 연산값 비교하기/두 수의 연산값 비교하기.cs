using System;

public class Solution {    
    public int solution(int a, int b) {
        int result1 = int.Parse($"{a}{b}");
        int result2 = 2*a*b;
        return result1>=result2? result1:result2;
    }
   // public int solution(int a, int b) {
   //     int result1 = a*Rank(b) + b;
   //     int result2 = 2*a*b;
   //     return result1>=result2? result1 : result2;
   // }
   // public int Rank(int n){
   //     if(n==0)
   //         return 1;
   //     return 10*Rank(n/10);
   // }
}