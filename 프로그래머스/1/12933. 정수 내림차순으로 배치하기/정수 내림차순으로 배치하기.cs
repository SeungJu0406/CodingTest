using System;

public class Solution {
    public long solution(long n) {
        string str= $"{n}";
        long[] sortArray = new long[str.Length];
        int index= 0;
        while(n>0){
            sortArray[index++] = (long)(n%10);
            n /= 10;
        }
        Array.Sort(sortArray);
        index= sortArray.Length;
        long answer = 0;
        for(int i = 0 ; i < sortArray.Length;i++){
            answer+= sortArray[i] * (long)Math.Pow(10,i);
        }
        return answer;
    }
}