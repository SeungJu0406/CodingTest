using System;

public class Solution {
    public string solution(string[] strList, string ex) {
        for(int i = 0 ; i < strList.Length; i++){
            if(strList[i].Contains(ex)){
                strList[i] ="";
            }
        }
        string answer= "";
        foreach(string s in strList){
            answer += s;
        }
        return answer;
    }
}