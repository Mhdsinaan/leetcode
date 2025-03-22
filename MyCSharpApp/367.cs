public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
    
      if(x%2==0){
        return x/2;
      }else{
        return-1;
      }
        
    }
    static void Main(){
        Solution sol=new Solution();
        Console.WriteLine(sol.SumOfTheDigitsOfHarshadNumber(10));
         Console.WriteLine(sol.SumOfTheDigitsOfHarshadNumber(23));
    }
}