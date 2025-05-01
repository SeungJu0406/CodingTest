using System;

public class Solution {
    public int[] solution(int n, long left, long right)
    {

        int[] answer = new int[right - left + 1];

        for(int i = 0; i< answer.Length; i++)
        {
            long index = left + i;

            int num1 = (int)(index % n + 1);
            int num2 = (int)(index / n + 1);

            answer[i] = num1 >= num2 ? num1 : num2; 
        }

        return answer;
    }
}