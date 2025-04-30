using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount)
    {
        List<string> tempList = new List<string>(); // 연속 10일 할인 리스트
        int answer = 0;

        for(int i = 0; i< discount.Length; i++) // 날짜 만큼 반복
        {
            tempList.Clear(); // 할인리스트 초기화
            for(int j = 0; j < 10; j++) // 10일만큼 반복
            {
                if (i + j >= discount.Length)
                    continue;
                tempList.Add(discount[i+j]); // 할인 품목 리스트 추가       
            }
            bool success = true;
            for (int j = 0; j < want.Length; j++) // 사고자하는 품목 만큼 반복
            {
                int count = tempList.Where(s => s == want[j]).Count(); // 10일간 할인 품목에서 원하는 품목의 개수 체크
                if (count != number[j]) //  개수만큼 같지않으면 실패 처리 후, 반복 종료
                {
                    success = false;
                    break;
                }
            }
            if (success == true) // 성공 시 반환값 1 추가
            {
                answer++;
            }
        }
        return answer;
    }
}