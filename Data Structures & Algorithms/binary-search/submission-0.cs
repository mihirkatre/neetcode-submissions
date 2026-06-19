public class Solution {
    public int Search(int[] nums, int target) {
        //this is a pre-built function solution, I will also be solving using custom func.
        int index = Array.BinarySearch(nums, target);
        //found target or -1
        return index >= 0 ? index : -1;
    }
}