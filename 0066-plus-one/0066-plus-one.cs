public class Solution {
    public int[] PlusOne(int[] digits) {

        int n=digits.Length-1;
        for(int i=n;i>=0;i--){
            if(digits[i]<9){
                digits[i]++;
                return digits;
            }else{
               digits[i] = 0;
               
            }
        }
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
             
    




        
 