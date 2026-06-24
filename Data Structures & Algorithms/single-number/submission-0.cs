public class Solution
{
    public int SingleNumber(int[] nums)
    {
        // Initialize result to 0
        int res = 0;

        // Loop through every number in the array
        foreach (int num in nums)
        {
            // XOR the current number with res
            res ^= num;
        }

        // The remaining value will be the number that appears only once
        return res;
    }
}