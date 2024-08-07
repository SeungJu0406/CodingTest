using System;

public class Solution {
    public int solution(int n) {
        int result = 0;
        if(n%2!=0){
            for(int i = n ; i >= 0 ; i-=2){
                result += i;
            }
        }
        else{
            for(int i = n ; i >= 0 ; i-=2){
                result += i*i;               
            }
        }
        return result;           
    }
}