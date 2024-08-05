using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        List<int> answerList = new List<int>();
        foreach(int i in numlist){
            if(i%n==0)
                answerList.Add(i);
        }
        int[] answer = answerList.ToArray();
        return answer;
    }
}