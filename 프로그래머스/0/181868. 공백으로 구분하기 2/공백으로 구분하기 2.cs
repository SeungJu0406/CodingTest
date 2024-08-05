using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        List<string> list = new List<string>();
        string[] temp=my_string.Split(" ");
        foreach(string s in temp){
            if(s!="")
                list.Add(s);
        }
        return list.ToArray();
    }
}