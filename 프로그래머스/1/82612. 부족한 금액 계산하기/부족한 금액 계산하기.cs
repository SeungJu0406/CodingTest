using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalPrice = 0;

        for (int i = 1; i <= count; i++)
        {
            totalPrice += price * i;
        }

        long answer = 0;
        answer = (long)money - totalPrice;

        return answer > 0 ? 0 : -answer;
    }
}