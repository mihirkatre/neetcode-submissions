public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int maxP = 0;

        while (right < prices.Length){
            if(prices[left] < prices[right]){
                //profitable day
                int profit = prices[right] - prices[left];
                maxP = Math.Max(maxP, profit);
            }
            else{
                //loss day
                left = right;
            }
            right++;
        }
        return maxP;
    }
}
