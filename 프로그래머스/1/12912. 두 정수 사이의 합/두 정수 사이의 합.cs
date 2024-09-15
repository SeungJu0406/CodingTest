public class Solution {
    public long solution(int a, int b) {
        int max = a > b ? a : b; 
        int min = a < b ? a : b;
        
        long result = 0;
        for( int i = min ; i <= max ; i++){
            result += i;
        }
        return result;
    }
}