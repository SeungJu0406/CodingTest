using System;

public class Solution {
    public string[] solution(string[] strings, int n)
    {
        //strings의 n번째 인덱스를 가장 앞으로가져옴
        for (int i = 0; i < strings.Length; i++)
        {
            char temp = strings[i][n];
            strings[i]=strings[i].Remove(n,1);
            strings[i] = temp + strings[i];
        }
        //후에 Sort
        Array.Sort(strings);
        //그리고 맨앞의 문자를 다시 n번쨰 자리에 위치
        for (int i = 0; i < strings.Length; i++)
        {
            char temp = strings[i][0];
            strings[i] = strings[i].Remove(0, 1);
            strings[i] = strings[i].Insert(n,$"{temp}");
        }
        return strings;
    }
}
