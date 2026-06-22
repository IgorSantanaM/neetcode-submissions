public class Solution {
    public bool IsAnagram(string s, string t) {
        var sorted1 = string.Concat(s.OrderBy(x => x));
        var sorted2 = string.Concat(t.OrderBy(x => x));

        return sorted1 == sorted2;
    }
}
