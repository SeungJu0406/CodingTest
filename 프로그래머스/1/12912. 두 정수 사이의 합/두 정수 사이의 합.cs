using System;

public class Solution {
    public long solution(int a, int b) {
        int max = a > b ? a : b; 
        int min = a < b ? a : b;
        
        // 등차수열의 합 : (첫째항+마지막항)*항의 개수 / 2
        return ((long)(max+min)*(long)(max-min+1))/2; 
    }
}