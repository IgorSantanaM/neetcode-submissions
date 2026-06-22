public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int remain = target - nums[i];
            if(dic.ContainsKey(remain))
            {
                return[dic[remain], i];
            } 
            dic[nums[i]] = i;
        }
        return [];
    }
}