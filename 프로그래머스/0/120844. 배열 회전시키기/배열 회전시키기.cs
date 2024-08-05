using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int temp = 0;
        if(direction=="left"){
            for(int i=0; i<numbers.Length-1;i++){
                if(i==0)
                    temp =numbers[i];
                numbers[i]=numbers[i+1];
                if(i==numbers.Length-2)
                    numbers[numbers.Length-1]=temp;
            }
        }
        else{
            for(int i=numbers.Length-1; i>0;i--){
                if(i==numbers.Length-1)
                    temp =numbers[i];
                numbers[i]=numbers[i-1];
                if(i==1)
                    numbers[0]=temp;
            }
        }
        return numbers;
    }
}