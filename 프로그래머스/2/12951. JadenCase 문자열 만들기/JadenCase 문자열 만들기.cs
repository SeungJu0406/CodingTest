using System;

public class Solution {
    public string solution(string s) {
        string result ="";
        char prev = ' ';
        foreach(char c in s){
            if(prev.Equals(' ')){
                result += Char.ToUpper(c);
            }
            else{
                result += Char.ToLower(c);
            }
            prev = c;
        }
        return result;
    }
}