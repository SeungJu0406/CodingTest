using System;

public class Solution {
    public string solution(string[] strList, string ex) {
        string answer= "";
        for(int i = 0 ; i < strList.Length; i++){
            if(!(strList[i].Contains(ex))){
                answer+=strList[i];
            }
        }
        return answer;        
   } 
}