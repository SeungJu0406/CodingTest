public class Solution {
    public bool solution(int x) {
        int result = 0;
        int n = x;
        while(n>0){
            result += n%10;
            n/=10;
        }
        if(x%result == 0 )
            return true;
        else
            return false;
    }
}