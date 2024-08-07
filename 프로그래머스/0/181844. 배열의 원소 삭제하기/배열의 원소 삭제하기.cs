using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] deleteList) {
        List<int> result = new List<int>();
        Array.Sort(deleteList);
        for (int i = 0; i < arr.Length; i++)
        {
            result.Add(arr[i]);
            for (int j = 0; j < deleteList.Length; j++)
            {               
                if (arr[i] == deleteList[j]){
                    result.Remove(arr[i]);
                    break;
                }
            }
        }
        return result.ToArray();
    }
}