using System;

class Solution 
{
    public int solution(int n) 
   {
        string binN = Convert.ToString(n,2);
        int number = binN.Replace("0","").Length;
        int result = n;
        while(true){
            result++;
            string binResult = Convert.ToString(result,2);
            int resultNumber = binResult.Replace("0","").Length;
            if(resultNumber == number)
                break;
        }
        return result;
    }
}