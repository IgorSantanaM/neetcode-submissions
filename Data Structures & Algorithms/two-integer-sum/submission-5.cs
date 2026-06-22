public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var remain = target - nums[i];

            if(map.ContainsKey(remain))
                return [map[remain], i];
            map[nums[i]] = i;
        }
        return [0,0];
    }
}
