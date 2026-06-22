public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2];
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            var remains = target - nums[i];
            if(map.ContainsKey(remains))
                result =  [map[remains], i];
        map[nums[i]] = i;
        }
       return result;
    }
}