using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(char c in my_string){
            if(Char.IsUpper(c)){              
                answer += Char.ToLower(c);
            }
            else{
                answer += Char.ToUpper(c);
            }
        }
        return answer;
    }
}