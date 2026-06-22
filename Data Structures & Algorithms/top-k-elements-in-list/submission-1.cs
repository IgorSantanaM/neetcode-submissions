public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];

        for(int i = 0; i < freq.Length; i++)
            freq[i] = new List<int>();

        foreach(var num in nums)
        {
            if(!map.ContainsKey(num))
                map[num] = 0;
            map[num]++;
        }

        foreach(var pair in map)
            freq[pair.Value].Add(pair.Key);

        var res = new int[k];
        var index = 0;

        for(int i = freq.Length - 1; i > 0 && index < k; i--)
        {
            foreach(var num in freq[i])
            {
                res[index++] = num;
                if(index == k)
                    return res;
            }
        }

        return res;
    }
}
