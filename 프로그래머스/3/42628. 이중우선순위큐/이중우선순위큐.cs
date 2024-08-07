using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] operations) {
        List<int> list = new List<int>();
        //입력만큼 반복
        for(int i = 0 ; i<operations.Length;i++){
        //첫글자가 I 일경우와 D일경우 분리
            if(operations[i][0]=='I'){
                //I일 경우 List값에 집어넣음
                list.Add(int.Parse(operations[i].Replace("I ","")));
                }
            else if(operations[i][0]=='D'){
                int commend=int.Parse(operations[i].Replace("D ",""));
                if(commend==1 && list.Count>0){
                    list.Remove(list.Max());
                }
                else if(commend==-1 && list.Count>0){
                    list.Remove(list.Min());
                }
            }
                   
        //D 일경우 -1일 경우와 1일 경우로 분리
        //-1일 경우 가장 작은 값 제거
        //1일 경우 가장 큰 값 제거
        }
        int[] result = new int[2]; 
        result[0]= list.Count > 0 ? list.Max() : 0;
        result[1]= list.Count > 0 ? list.Min() : 0;
        return result;
    }
}