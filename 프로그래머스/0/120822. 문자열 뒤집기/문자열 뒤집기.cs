using System;

public class Solution {
    public string solution(string my_string) {
        string result = "";
        for(int i = 0;i<my_string.Length;i++){
            result+=my_string[my_string.Length-1-i];
        }
        return result;
    }
}