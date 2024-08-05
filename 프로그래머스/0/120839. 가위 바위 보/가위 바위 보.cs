using System;

public class Solution {
    public string solution(string rsp) {
            string result = ""; // 결과 반환용
            foreach (char i in rsp) // 입력 문자열에서 반복
            {
                switch (i) // 문자열 자리수마다 경우의 수
                {
                    case '0': // 0(주먹)일때 5(보)
                        result += "5";
                        break;
                    case '2':// 2(가위)일떄 0(주먹)
                        result += "0";
                        break;
                    case '5': // 5(보)일때 2(가위)
                        result += "2";
                        break;
                }
            }
            return result;
    }
}