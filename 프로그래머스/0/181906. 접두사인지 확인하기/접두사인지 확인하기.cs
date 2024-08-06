using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        if(my_string.Length<is_prefix.Length)
            return 0;
        string prefix ="";
        for(int i = 0 ; i<is_prefix.Length; i++){
            prefix += my_string[i];
        }
        return prefix.Equals(is_prefix)? 1 : 0 ;
    }
}