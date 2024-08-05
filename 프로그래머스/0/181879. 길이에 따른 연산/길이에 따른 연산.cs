using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        return num_list.Length<=10?  Function(num_list) : num_list.Sum();
    }
    public int Function(int[] num_list){
        int answer = 1;
        foreach(int c in num_list){
            answer*=c;            
        }
        return answer;  
    }
}
