using System;

public class Solution {
    public int solution(string str1, string str2) {
        int index = 0;
        bool isRunning = false;
        string answerStr = "";
        foreach(char c in str1){
            if(c==str2[index])
                isRunning=true;
            else{
                isRunning=false;
                index = 0;
                answerStr ="";
            }
            if(isRunning){
                answerStr += str2[index];
                index++;
                if(answerStr.Length==str2.Length)
                    return 1;   
            }                    
        }
        return 2;
    }
}