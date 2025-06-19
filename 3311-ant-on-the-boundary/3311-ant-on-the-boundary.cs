public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int count=0;
        int position=0;

        foreach(int s in nums){
            position+=s;
            if(position==0){
                count++;
            }

        }
        return count;
    }
}