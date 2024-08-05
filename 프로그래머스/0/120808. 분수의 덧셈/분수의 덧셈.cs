using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
            int denominator = denom1 * denom2;
            int numerator = (numer1 * denom2) + (numer2 * denom1);
            int bigNumber=0;
            int smallNumber=0;
            int greatestDivisor = 0;
            int[] fraction =new int[2];
            if(denominator>numerator){
                bigNumber=denominator;
                smallNumber=numerator;
                }
            else if(denominator<numerator){
                bigNumber=numerator;
                smallNumber=denominator;
            }
            else{
                fraction[0]=1;
                fraction[1]=1;
                return fraction;
                }
            for(int i = 1; i<=smallNumber;i++){
                if((bigNumber%i==0)&&(smallNumber%i==0))
                    greatestDivisor=i;
            }
            fraction[0]=numerator/greatestDivisor;
            fraction[1]=denominator/greatestDivisor;
            return fraction;
    }
}