using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(char c in my_string){
            switch(c){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    break;
                default:
                    answer += c;
                    break;
            }
        }
        return answer;
    }
}