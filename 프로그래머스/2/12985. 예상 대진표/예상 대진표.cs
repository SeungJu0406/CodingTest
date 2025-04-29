using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

        while (true)
        {
            answer++;

            if(a%2 != 0) // a가 홀수일 때
            {
                a++;
            }
            if(b%2 != 0) // b가 홀수일 때
            {
                b++;
            }
            if(a == b) // a와 b가 같음 == 이번에 붙음
            {
                // 반복 종료, 현재까지 센 카운트 반환
                break;
            }
            else // a와 b가 다름 == 다음번에 붙음
            {
                a /= 2;
                b /= 2;
            }
        }
        return answer;
    }
}