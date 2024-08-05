using System;

public class Solution {
    public int solution(string myString, string pat) {
        return myString.ToUpper().Contains(pat.ToUpper())? 1:0;
    }
}