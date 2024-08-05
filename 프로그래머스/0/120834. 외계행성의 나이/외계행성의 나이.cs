using System;

public class Solution {
    public string solution(int age) {
        string result = "";
        while(age>0){
            result=(char)(age%10+97)+result;
            age/=10;
        }
        return result;
    }
}