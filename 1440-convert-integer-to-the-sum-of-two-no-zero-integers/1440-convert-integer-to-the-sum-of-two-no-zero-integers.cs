public class Solution {
    public int[] GetNoZeroIntegers(int n) {

        for(int a=1;a<n;a++){
            int b;

            b=n-a;
            if(isNonZero(a)&& isNonZero(b)){
                return new int[] { a, b };
            }
        }
         return null;
        
    }
    private bool isNonZero(int num){
        while(num>0){
            if(num%10==0){
                return false;
            }
            num/=10;

        }
        return true;
    }
}