public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();
        int count = 0;
        int len = nums.Length;

        while(count < len)
        {
            if(!dup.Add(nums[count]))
            {
                return true;
            }
            count++;
        }
        return false;
    }
}