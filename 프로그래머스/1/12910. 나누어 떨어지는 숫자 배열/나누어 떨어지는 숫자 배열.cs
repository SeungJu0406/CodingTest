using System.Collections.Generic;

public class Solution {
    
    private List<int> _answerList = new List<int>();
    
    public int[] solution(int[] arr, int divisor) {
        _answerList.Clear();
        
        foreach(int i in arr)
        {
            if(i % divisor == 0){
                _answerList.Add(i);
            }   
        }
       if( _answerList.Count== 0 )
       {
           _answerList.Add(-1);
       }
        _answerList.Sort();
        return _answerList.ToArray();
    }
}