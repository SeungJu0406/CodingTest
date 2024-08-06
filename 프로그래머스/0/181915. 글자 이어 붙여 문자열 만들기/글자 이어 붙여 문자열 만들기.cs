using System;

public class Solution {
    public string solution(string myString, int[] indexList) {
        string result = "";
        for(int i = 0 ; i < indexList.Length ; i++){
            result += myString[indexList[i]];
        }
        return result;
    }
}