using System.Collections.Generic;    

public class Solution 
    {
        public int solution(int[] arr)
        {
            Stack<int> result = new Stack<int>();
            result.Push(1);
            for (int i = 0; i < arr.Length; i++) 
            {
                int multiple = Function(result.Peek(), arr[i]);
                result.Push(multiple);
            }
            return result.Peek();
        }
        public int Function(int n, int m)
        {
            int result = n;
            while(result%m != 0)
            {
                result += n;
            }
            return result;
        }
    }