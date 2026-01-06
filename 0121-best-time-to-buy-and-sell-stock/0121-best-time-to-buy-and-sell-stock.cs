public class Solution {
    public int MaxProfit(int[] prices) {

        int minp=int.MaxValue;
        int maxprofit=0;

        foreach(int price in prices){
            if(price<minp){
                minp=price;
            }else{
                int profit=price-minp;
               if(profit>maxprofit){
                maxprofit=profit;
               }

            }
        }

        return maxprofit;
        
    }
}