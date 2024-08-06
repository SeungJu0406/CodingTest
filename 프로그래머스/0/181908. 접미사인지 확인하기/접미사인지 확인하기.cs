using System;
using System.Linq;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        if(my_string.Length<is_suffix.Length)
            return 0;
        string result ="";
        for(int i = my_string.Length-is_suffix.Length; i<my_string.Length;i++){
            result += my_string[i];
        }
        return result.Equals(is_suffix)? 1:0;
    }
}