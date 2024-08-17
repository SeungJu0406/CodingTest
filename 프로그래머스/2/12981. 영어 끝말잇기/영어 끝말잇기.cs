using System.Collections.Generic;

public class Solution
    {
        public int[] solution(int n, string[] words)
        {

            Stack<string> stack = new Stack<string>();
            int order = 1;
            int count = 1;
            int index = 0;
            bool success = true;
            bool gameRunniung = false;
            string thisTurn = words[index];
            while (true)
            {
                
                index++;
                if (!(success) || index >= words.Length)
                {
                    break;
                }
                order++;
                if (order > n)
                {
                    order = 1;
                    count++;
                }             
                stack.Push(thisTurn);
                thisTurn = words[index];
                success = Compare(stack, stack.Peek(), thisTurn);
            }
            int[] answer = new int[2];
            if (success)
            {
                answer[0] = 0;
                answer[1] = 0;
                return answer;
            }
            else
            {
                answer[0] = order;
                answer[1] = count;
                return answer;
            }
        }
        public bool Compare(Stack<string> stack, string first, string second)
        {
            if (first[first.Length - 1].Equals(second[0]))
                if (stack.Contains(second))
                    return false;
                else
                    return true;
            else
                return false;
        }
    }