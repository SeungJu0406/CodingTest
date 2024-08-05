using System;

public class Solution {
    public int solution(int[] array) {
        int[] resultArray = new int[array.Length];
        int maxCount = 0;
        int maxNumber =0;
        for(int i =0 ; i < array.Length ; i++){
            int temp =0;
            for(int j =0; j < array.Length ; j++){
                if(array[i]==array[j])
                    temp++;                
            }
            resultArray[i]=temp;
            if(temp>maxCount){
                maxCount = temp;
                maxNumber = array[i];
            }
        }
    
        for(int i =0 ; i < array.Length ; i++){
            for(int j =0 ;j < array.Length ; j++){
                    if ((resultArray[i] == maxCount) && (array[i] != array[j])&&(resultArray[i]== resultArray[j]))
                       return -1;
            }
        }
        return maxNumber;
        
    }
}

                    