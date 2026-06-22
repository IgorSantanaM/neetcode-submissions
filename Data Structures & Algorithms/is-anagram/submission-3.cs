public class Solution {
    public bool IsAnagram(string s, string t) {

        var sorted1 = String.Concat(s.OrderBy(x => x));
        var sorted2 = String.Concat(t.OrderBy(x => x));

        return sorted1 == sorted2;
        
    }
}
