using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s)
    {
        int answer = 0;

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            bool success = true;
            stack.Clear();
            stack.Push(s[i]);
            for (int j = 1; j < s.Length;j++)
            {
                char prev;
                char next = s[(i + j) % s.Length];

        
                if (stack.Count > 0)
                {
                    prev = stack.Peek();

                    switch (prev)
                    {
                        case '(':
                            if (ReadParentheses(stack, next, ')') == false)
                            {
                                success = false;
                            }
                            break;
                        case '{':
                            if (ReadParentheses(stack, next, '}') == false)
                            {
                                success = false;
                            }
                            break;
                        case '[':
                            if (ReadParentheses(stack, next, ']') ==false)
                            {
                                success = false;
                            }
                            break;
                        default:
                            success = false;
                            break;
                    }
                }
                else
                {
                    stack.Push(next);
                    continue;
                }

                if (success == false)
                    break;
            }
            if(success == true && stack.Count == 0)
            {
                answer++;
            }
        }

        return answer;
    }

    private bool ReadParentheses(Stack<char> stack, char next, char parentheses)
    {
        if (next == parentheses)
        {
            stack.Pop();
        }
        else if (next == ']' || next == '}' || next == ')')
        {
            return false;
        }
        else if(next == '[' || next == '{' || next == '(')
        {
            stack.Push(next);
        }
        return true;
    }
}