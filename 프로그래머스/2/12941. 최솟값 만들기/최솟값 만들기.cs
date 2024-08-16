using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        Array.Sort(A);
        Array.Sort(B);
        int size = A.Length;
        int result = 0;
        for(int i = 0 ; i < size; i++){
            result += A[i]*B[(size-1) -i ];
        }
        return result;
    }
}