using System.Linq;
public class Solution {
    public string solution(string s) {
        string[] strArr =s.Split(" ");
        int[] intArr =new int[strArr.Length];
        for(int i = 0 ; i < strArr.Length ; i++){
            intArr[i] = int.Parse(strArr[i]);
        }
        s = $"{intArr.Min()} {intArr.Max()}";
        return s;
    }
}