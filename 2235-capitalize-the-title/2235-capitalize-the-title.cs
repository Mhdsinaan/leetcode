public class Solution {
    public string CapitalizeTitle(string title) {

        string[] words=title.Split(' ');
        for(int i=0;i<words.Length;i++){

            if(words[i].Length>=3){

               words[i]= char.ToUpper(words[i][0])+ words[i].Substring(1).ToLower();
            }else{
               words[i]= words[i].ToLower();

            }

          

        }
         return string.Join(' ',words);
        
    }
}