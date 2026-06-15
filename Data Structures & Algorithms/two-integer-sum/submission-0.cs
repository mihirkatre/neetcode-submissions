public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> prevValue = new Dictionary<int, int>();
        for (int i=0; i < nums.Length; i++){
            var difference = target - nums[i];
            if(prevValue.ContainsKey(difference)){
                return new int[] {prevValue[difference], i};
            }
            prevValue[nums[i]] = i;
        }
        return new int[] {};
    }
}
