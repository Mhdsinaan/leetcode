public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
          
        int org=x;
        int sum=0;
        while(x>0){
            sum+=x%10;
            x/=10;
        }
        if(org%sum==0){
            return sum;
        }else{
            return -1;
        }





        
    }
}