using System.Linq;

public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        answer = (double)arr.Sum()/(double)arr.Length;
        
        return answer;
    }
}