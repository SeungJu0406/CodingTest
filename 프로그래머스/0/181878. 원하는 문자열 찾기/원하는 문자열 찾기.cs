using System;

public class Solution {
    public int solution(string myString, string pat) {
        myString= myString.ToUpper();
        pat=pat.ToUpper();
        return myString.Contains(pat)? 1:0;
    }
}