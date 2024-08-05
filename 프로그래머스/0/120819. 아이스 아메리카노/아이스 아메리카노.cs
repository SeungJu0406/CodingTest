using System;

public class Solution {
    public int[] solution(int money) {
        int[] resultArray = new int[2]{money/5500,money%5500};
        return resultArray;

        
    }
}