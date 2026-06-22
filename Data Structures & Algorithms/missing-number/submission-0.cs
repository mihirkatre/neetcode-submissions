public class Solution {

    //Key Idea: Missing Number = Expected Sum - Actual Sum
    //Expected sum of [0, 1, 2, ..., n] = n * (n + 1) / 2
    //Actual sum = sum of all numbers in nums
    //Difference = the missing number

    public int MissingNumber(int[] nums) {
        // Initialize result with n (the upper bound of our range [0, n])
        // This accounts for the fact that we have n elements but need n+1 possible values
        int result = nums.Length;

        // Iterate through each index and element in the array
        for (var i = 0; i < nums.Length; i++){
            // Add the index (i) and subtract the actual value (nums[i])
            // This effectively computes: n + (0+1+2+...+(n-1)) - (nums[0]+nums[1]+...+nums[n-1])
            // Which equals: expected_sum - actual_sum = missing_number
            result += i - nums[i];
        }
        
        // Return the missing number
        return result;
    }
}