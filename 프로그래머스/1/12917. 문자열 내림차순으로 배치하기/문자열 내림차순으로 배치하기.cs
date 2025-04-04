using System;
using System.Text;

public class Solution {
    private StringBuilder sb = new StringBuilder();
    public string solution(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        Array.Reverse(chars);

        sb.Clear();
        foreach(char c in chars)
        {
            sb.Append(c);
        }
        return sb.ToString();
    }
}