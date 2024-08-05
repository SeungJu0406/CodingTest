using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] result = new int[num2-num1+1];
        int count = 0;
        for(int i = 0 ; i < numbers.Length ; i++){
            if(num1<=i && i<=num2){
                result[count]=numbers[i];
                count++;
                }
        }
        return result;
    }
}