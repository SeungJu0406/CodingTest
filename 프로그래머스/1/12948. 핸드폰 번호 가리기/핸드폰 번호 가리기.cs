using System.Text;
public class Solution
{
    private StringBuilder sb = new StringBuilder();
    public string solution(string phone_number)
    {
        sb.Clear();
        int lastNum = phone_number.Length - 4;

        for (int i = 0; i < phone_number.Length; i++)
        {
            if (i >= lastNum)
            {
                sb.Append(phone_number[i]);
            }
            else
            {
                sb.Append("*");
            }
        }
        return sb.ToString();
    }
}