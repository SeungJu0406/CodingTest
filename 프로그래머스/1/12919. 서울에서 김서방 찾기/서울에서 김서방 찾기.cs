public class Solution {
    public string solution(string[] seoul) {
        int index = 0;
        foreach(string str in seoul){
            if(str == "Kim")
                break;
            index++;
        }
        return $"김서방은 {index}에 있다";
    }
}