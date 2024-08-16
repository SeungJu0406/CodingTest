public class Solution {
    public int solution(int n) {
        int first = 0;
        int second = 1;
        int result=0;
        for(int i = 2 ; i <= n ; i++){
            first=first%1234567;
            second=second%1234567;
            result = first + second;
            first = second;
            second =result;
        }
        
        return (int)(result%1234567);
    }
}