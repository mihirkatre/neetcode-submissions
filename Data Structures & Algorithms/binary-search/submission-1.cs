public class Solution{
    public int Search(int[] nums, int target){
        //left and right pointer at start and end of the sorted array
        int l = 0;
        int r = nums.Length - 1;

        //loop until l=r
        while (l < r){
            //find out midpoint and compare with target
            int m = (l + r) / 2;
            //if target is greater than mid point, move the left pointer towards right.
            if(nums[m] < target){
                l = m + 1;
            }
            //else move the right pointer towards left
            else{
                r = m;
            }
        }
        //this is where loop end and left and right pointer meet, either the target was found, else -1
        return (l < nums.Length && nums[l] == target) ? l : -1;
    }
}