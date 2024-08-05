using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int count = 1;
        int throwball = 0;
        int result = 0;
        while(true){
            for(int i = 0; i<numbers.Length;i++){                      
                if(throwball==2){
                    count++;
                    throwball=0;
                }
                if(count==k){
                    result=numbers[i];
                    break;
                    }    
                throwball++;
            }
            if(result!=0)
                break;
        }
        return result;
    }
}