using System;

public class Solution {
    public string solution(string my_string, int n) {
        int size = my_string.Length;
        return my_string.Remove(0,size-n);
    }
}