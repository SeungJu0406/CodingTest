using System;

public class Solution {
    public int solution(int n) {
        int piece = n%7;
        if(piece==0)
            return n/7;
        return n/7+1;
    }
}