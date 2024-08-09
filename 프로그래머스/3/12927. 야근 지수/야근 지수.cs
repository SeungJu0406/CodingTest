using System;
using System.Collections.Generic;
public class Solution {
    public long solution(int n, int[] works) {
        long answer = 0;
        Array.Sort(works);
        int max = works[works.Length-1];
        while(n>0)
        {
            for(int i=works.Length-1; i>=0; i--)
            {
                if(n<=0) break;
                if(max==works[i])
                {
                    works[i]--;
                    n--;
                }
            }
            max--;
            if(max==0) break;
        }
        for(int i=0; i<works.Length; i++)
        {
            answer += (long) Math.Pow(works[i],2);
        }
        return answer;


    }
}