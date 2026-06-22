public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] result = new int[2];
        Dictionary<int, int> map = new();

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];

            if(map.ContainsKey(diff))
                result =  [map[diff], i];
            map[nums[i]] = i;
        }

        return result;
    }
}
