public class Solution {
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];

        int a = n;
        int b = m;

        int count = 1;

        int result = 1;
        while(a >= count && b >= count)
        {
            if(a%count == 0 && b%count == 0)
            {
                a /= count;
                b /= count;

                result *= count;
            }
            else
            {
                count++;
            }

            if (count == 1)
            {
                count++;
            }
        }

        answer[0] = result;
        answer[1] = result * a * b;

        return answer;
    }
}