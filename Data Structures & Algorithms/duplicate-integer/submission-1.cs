public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();
        int count = 0;
        int len = nums.Length;

        while(count < len)
        {
            bool res = dup.Add(nums[count]);
            if(!res)
            {
                return true;
            }
            count++;
        }
        return false;
    }
}