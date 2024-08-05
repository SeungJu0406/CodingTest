using System;

public class Solution {
        public string solution(string letter)
        {
            string[] morseCode = letter.Split(' ');
            string[] convertCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string result = "";
            for (int i = 0; i < morseCode.Length; i++)
            {
                for (int j = 0; j < convertCode.Length; j++)
                {
                    if (morseCode[i] == convertCode[j])
                    {
                        result += (char)(97 + j);
                    }
                }
            }
            return result;
        }
}