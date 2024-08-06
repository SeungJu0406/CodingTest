using System;

public class Solution {
    public int solution(int[] num_list) {
        Array.Reverse(num_list);
        int oddIndex = 1;
        int evenIndex = 1;
        int odd =0;
        int even = 0;
        for(int i = 0 ; i < num_list.Length ;i++){
            if(num_list[i]%2==0)
                even += num_list[i]*Pow(evenIndex++);
            else
                odd += num_list[i]*Pow(oddIndex++);
        }
        return even+odd;
    }
    public int Pow (int n){
        if(n<=1)
            return 1;
        return 10*Pow(n-1);
    }
}