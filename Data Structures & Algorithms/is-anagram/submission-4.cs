public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

       var map1 = new Dictionary<char, int>();
       var map2 = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
            if(!map1.ContainsKey(s[i]))
                map1[s[i]] = 0;
            map1[s[i]]++;
            if(!map2.ContainsKey(t[i]))
                map2[t[i]] = 0;
            map2[t[i]]++;
        }

        foreach(var c in map1){
            if(!map2.TryGetValue(c.Key, out var _) || map1[c.Key] != map2[c.Key])
                return false;
        }

        return true;
    }
}
