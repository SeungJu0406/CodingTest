using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
       Stack<char> stack = new Stack<char>();
       foreach(char c in s){
           if(stack.Count>0&&( stack.Peek()=='('&& c==')' ))//스택에 아무것도 없을때, 마지막과 짝이 안맞을때
               stack.Pop();
           else
               stack.Push(c);
       }
       return stack.Count==0? true : false;
    }
}