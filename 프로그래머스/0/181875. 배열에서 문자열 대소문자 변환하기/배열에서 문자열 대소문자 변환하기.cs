using System;

public class Solution {
    public string[] solution(string[] strArr) {
        for(int i = 0; i < strArr.Length ; i++){
            if(i%2==0){
                strArr[i]=strArr[i].ToLower();
            }
            else{
                strArr[i]=strArr[i].ToUpper();
            }
        }
        return strArr;
    }
}