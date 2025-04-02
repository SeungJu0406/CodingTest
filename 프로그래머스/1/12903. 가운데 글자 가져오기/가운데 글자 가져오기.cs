using System.Text;

public class Solution {
    private StringBuilder sb = new StringBuilder();
    public string solution(string s) {
        sb.Clear();
        int middle = s.Length / 2;
        if (s.Length % 2 != 0) 
        {
            sb.Append(s[middle]);
        }
        else
        {
            sb.Append(s[middle-1]).Append(s[middle]);
        }
        return sb.ToString();
    }
}