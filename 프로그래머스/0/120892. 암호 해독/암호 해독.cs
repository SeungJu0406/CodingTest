using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        for(int i = -1 ; i < cipher.Length; i += code){
            if(i==-1)
                continue;
            answer+=cipher[i];
        }
        return answer;
    }
}