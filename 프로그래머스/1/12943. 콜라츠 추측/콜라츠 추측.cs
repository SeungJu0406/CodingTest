public class Solution {
    public int solution(int num) {
        long answer = num;
        int count = 0;
        while(answer != 1)
        {
            count++;
            if (answer % 2 == 0) // 짝수일 때
            {
                answer /= 2; // 2로 나누기
            }
            else // 홀수일 때
            {
                answer *= 3; // 3 곱하고 1더하기
                answer++;
            }
            if (count > 500)
                break;
        }
        return count > 500 ? -1 :count ;
    }
}