using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer;
        if(num_list.Length<=10){
            answer = 1;
            foreach(int c in num_list){
                answer*=c;            
            }
            return answer;            
        }
        return num_list.Sum();
    }
}
