public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        string p=strs[0];
        for(int i=1;i<=strs.Length-1;i++){

         while(!strs[i].StartsWith(p)){
            p=p.Substring(0,p.Length-1);

            if(p==""){
                return "";
            }
         }
         
        }
        return p;
        
    }
}