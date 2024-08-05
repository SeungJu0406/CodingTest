using System;

public class Solution {
    public string solution(string my_string, string letter) {  
            string result = my_string.Replace(letter, "");
            return result;
    }
}