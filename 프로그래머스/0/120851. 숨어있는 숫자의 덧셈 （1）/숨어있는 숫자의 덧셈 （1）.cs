using System;

public class Solution {
    public int solution(string my_string) {
        int sum = 0;
        foreach(char c in my_string){
            if(Char.IsDigit(c)){
                sum += int.Parse(c.ToString());
            }
        }
        return sum;
    }
}
