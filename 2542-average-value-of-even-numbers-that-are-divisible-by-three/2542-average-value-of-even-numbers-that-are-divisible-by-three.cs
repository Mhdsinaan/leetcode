public class Solution {
    public int AverageValue(int[] nums) {
        int sum=0;
        int count=0;
        foreach(int n in nums){
            if(n%2==0 && n%3==0){
                sum+=n;
                count++;
            }
        }

        if (count>0){
            return sum/count;
        }else{
            return 0;
        }



        
    }
}