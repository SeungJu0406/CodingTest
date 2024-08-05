using System;

public class Solution {
    public int[] solution(int n) {
        int[] oddArray= new int[GetOddCount(n)];
        for(int i =0 ; i<=n ; i++){
          if(i%2==1)
            oddArray[i/2]=i;   
        } 
        return oddArray;
    }
    public int GetOddCount(int n){
        if(n%2==0)
            return n/2;
        return n/2+1;
    }
}