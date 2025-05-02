using System;

public class Solution
{
    public int solution(int k, int[,] dungeons)
{
    int[] hps = new int[dungeons.GetLength(0)];

    int count = Search(k, dungeons, hps, 0, dungeons.GetLength(0) - 1);

    return count;
}

private int Search(int k, int[,] dungeons, int[] hps, int start, int end)
{
    int maxCount = 0;

    if (start == end)
    {
        int count = 0;

        bool complete = false;

        hps[start] = k - dungeons[start, 1];

        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (complete == false && hps[i] + dungeons[i,1] >= dungeons[i, 0])
            {
                count++;
            }
            else
            {
                complete = true;
                break;
            }
        }

        return count;
    }

    for (int i = start; i <= end; i++)
    {
        Swap(ref dungeons[start, 0], ref dungeons[i, 0]);
        Swap(ref dungeons[start, 1], ref dungeons[i, 1]);

        hps[start] = k - dungeons[start, 1];
        int tempCount = Search(hps[start], dungeons, hps, start + 1, end);
        if (tempCount > maxCount)
        {
            maxCount = tempCount;
        }

        Swap(ref dungeons[start, 0], ref dungeons[i, 0]);
        Swap(ref dungeons[start, 1], ref dungeons[i, 1]);
    }

    return maxCount;
}

private void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
}