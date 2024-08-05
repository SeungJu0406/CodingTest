using System;

public class Solution {
        public int solution(int n)
        { 
            if (n < 1)
                return 0 ;
            if (n % 2 == 0)
                return n + solution(n - 1);
            return solution(n - 1);
        }
}