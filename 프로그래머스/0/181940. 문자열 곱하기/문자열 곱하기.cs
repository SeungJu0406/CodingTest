using System;

public class Solution {
    public string solution(string myString, int k) {
        string result ="";
        for(int i =0 ; i<k ; i++){
            result+=myString;
        }
        return result;
    }
}