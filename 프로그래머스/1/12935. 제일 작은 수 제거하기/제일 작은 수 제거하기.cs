using System.Linq;
public class Solution {
    public int[] solution(int[] arr)
    {
        if (arr.Length <= 1)
            return new int[] {-1};

        int[] answer = new int[arr.Length - 1];

        int min = arr.Min();

        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == min)
            {
                count--;
            }
            else
            {
                answer[count] = arr[i];
            }
            count++;
        }
        return answer;
    }
}