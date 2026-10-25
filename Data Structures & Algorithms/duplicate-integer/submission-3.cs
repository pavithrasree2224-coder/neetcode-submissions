public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();

        foreach(int n in nums)
        {
            if(!dup.Add(n))
            {
                return true;
            }
        }
        return false;      
    }
}