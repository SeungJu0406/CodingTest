using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                // arr1의 i번째 행의 j열의 수와 arr2의 i번째 열의 j행의 수와 곱하고 더한 값

                answer[i, j] = Func(i, j, arr1, arr2);
            }
        }
        return answer;
    }

    public int Func(int arr1Index, int arr2Index , int[,] arr1, int[,] arr2)
    {
        int answer = 0;

        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            int num1 = arr1[arr1Index, j];
            int num2 = arr2[j, arr2Index];

            answer += num1 * num2;
        }

        return answer;
    }
}