using System.Text;
public class Solution
{
    private StringBuilder sb = new StringBuilder();
    public string solution(int n)
    {
        sb.Clear();
        for (int i = 0; i < n; i++) 
        {
            if(i%2 == 1)
            {
                sb.Append("박");
            }
            else
            {
                sb.Append("수");
            }
        }
        return sb.ToString();
    }
}