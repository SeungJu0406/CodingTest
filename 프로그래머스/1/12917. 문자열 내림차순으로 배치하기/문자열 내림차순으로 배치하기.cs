using System;
using System.Text;

public class Solution {
    public string solution(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        Array.Reverse(chars);

        return new string(chars);
    }
}