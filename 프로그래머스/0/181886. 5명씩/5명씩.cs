using System;

public class Solution {
    public string[] solution(string[] names) {
        string[] result = new string[(names.Length-1)/5+1];
        int index = 0;
        for(int i = 0; i <names.Length ; i+=5){
            result[index++] = names[i];
        }
        return result;
    }
}