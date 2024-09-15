public class Solution {
    public int[] solution(long n) {
        string str = $"{n}";
        int[] answer = new int[str.Length];
        int index = 0;
        while(n>0){
            answer[index++] = (int)(n%10);
            n /= 10;
        }
        return answer;
    }
}