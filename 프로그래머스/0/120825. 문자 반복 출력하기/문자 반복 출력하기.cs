using System;

public class Solution {
    public string solution(string my_string, int n) {
        string result = "";
        for(int i = 0 ; i < my_string.Length ; i++){
            for(int j = 0 ; j < n ; j++){
                result += my_string[i];
            }
        }
        return result;
    }
}