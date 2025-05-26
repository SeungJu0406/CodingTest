using System;

public class Solution {
        public int solution(string t, string p)
    {
        int answer = 0;

        for(int i = 0; i < t.Length; i++)
        {    
            if (i <= t.Length - p.Length)
            {
                bool success = false;

                for (int j = 0; j < p.Length; j++)
                {
                    if ((int)t[i + j] < (int)p[j] )
                    {
                        success = true;
                        break;
                    }
                    else if((int)t[i + j] == (int)p[j])
                    {
                        success = true;
                        continue;
                    }
                    else
                    {
                        success = false;
                        break;
                    }
                }
                if(success == true)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}