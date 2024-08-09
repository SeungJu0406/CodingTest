using System;
using System.Linq;

public class Solution {
        public int[] solution(int[] array) {
        int max = array.Max();
        int[] result = {max, Array.IndexOf(array,max)};
        return result;
    }
}