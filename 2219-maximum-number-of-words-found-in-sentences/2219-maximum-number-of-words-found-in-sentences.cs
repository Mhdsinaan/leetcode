public class Solution {
    public int MostWordsFound(string[] sentences) {

        int max=0;

        foreach(string n in sentences ){
            int count=n.Split(' ').Length;
            if(count>max){
                max=count;
            }
        }

        return max;



        
    }
}