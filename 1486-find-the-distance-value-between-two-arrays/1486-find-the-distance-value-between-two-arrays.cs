public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {

        int count=0;
      

        foreach(int a in arr1){

              bool safe= true;

              foreach(int ar in arr2){

                if(Math.Abs(a-ar)<=d){
                    safe =false;
                    break;
                }
                
              }
              if(safe){
                
                count++;
              }

        }
        return count;
        
        
    }
}