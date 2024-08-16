using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int total = brown+yellow;
        int resultX=0;
        int resultY=0;
        for(int y = 3; y<total ;y++){
            int x=0;
            if(total%y == 0){
                x= total / y ;
            }
            int yellowX = x-2;
            int yellowY = y-2;
            if(yellow == yellowX*yellowY){
                resultX = x;
                resultY = y;
                break;
            }
        }
        int[] result = new int[2]{resultX,resultY};
        return result;
    }
}