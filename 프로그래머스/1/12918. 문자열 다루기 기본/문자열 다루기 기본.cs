public class Solution {
    public bool solution(string s)
    {
        return int.TryParse(s, out int result)&& (s.Length==4 || s.Length==6);
    }
}