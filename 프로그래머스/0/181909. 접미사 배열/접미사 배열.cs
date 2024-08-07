using System;

public class Solution {
    public string[] solution(string myString) {
        string[] strArr = new string[myString.Length];
        for(int i = 0; i < myString.Length; i++ ){
            string temp ="";
            for(int j = i ; j<myString.Length;j++){
                temp +=myString[j];
            }
            strArr[i]=temp;
        }
        Array.Sort(strArr);
        return strArr;
    }
}