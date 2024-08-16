using System;

public class Solution {
    public int[] solution(string s) {
        int[] result = new int[2];
        int size;
        int deleteZero = 0;
        int count = 0; 
        while(!(s.Equals("1"))){
            size = s.Length;
            s = s.Replace("0","");
            deleteZero += size - s.Length;
            s = Convert.ToString(s.Length,2);   
            count++;
        }
        result[0] = count;
        result[1] = deleteZero;
        return result;
    }
}