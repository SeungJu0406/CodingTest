public class Solution 
{
        public long solution(int n)
        {
            int result;
            result = Fibonacci(n);
            return result;
        }

        public int Fibonacci(int n)
        {
            int first = 1;
            int second = 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                first = first % 1234567;
                second = second % 1234567;
                result = first + second;
                first = second;
                second = result;
            }

            return (int)(result % 1234567);
        }
}