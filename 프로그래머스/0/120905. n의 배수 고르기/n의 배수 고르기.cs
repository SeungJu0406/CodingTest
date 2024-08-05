using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        List<int> answerList = new List<int>();
        foreach(int i in numlist){
            if(i%n==0)
                answerList.Add(i);
        }
        int[] answer = new int[answerList.Count];
        for(int i = 0 ; i< answer.Length ;i++){
            answer[i] = answerList[i];   
        }
        return answer;
    }
}