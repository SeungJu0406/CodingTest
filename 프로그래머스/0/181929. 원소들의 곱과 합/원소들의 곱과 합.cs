using System;
using System.Linq;

public class Solution {
    public int solution(int[] numList) {
        return ArrayMultiply(numList) < numList.Sum()*numList.Sum() ? 1 : 0;
    }
    public int ArrayMultiply(int[] numList){
        int answer = 1;
        for(int i = 0 ; i < numList.Length; i++){
            answer *=numList[i];
        }
        return answer;
    }
}