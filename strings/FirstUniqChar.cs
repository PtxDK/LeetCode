
public class Solution {
    public int FirstUniqChar(string s) {
        
        Dictionary<char, int> candidates = new Dictionary<char, int>();
        Dictionary<char, int> removed_candidates = new Dictionary<char, int>();
        
        for(int i = 0; i<s.Length; i++) {
            // try 
            if ( candidates.ContainsKey(s[i]) ) {
                candidates.Remove(s[i]);
                if ( !removed_candidates.ContainsKey(s[i]) ) {
                    removed_candidates.Add(s[i],i);
                }
            } else if ( !removed_candidates.ContainsKey(s[i]) ) {
                candidates.Add(s[i],i);
            }
        }
        
        if (candidates.Count == 0) {
            return -1;
        } else {
            return candidates.OrderBy(kvp => kvp.Value).First().Value;
        }
    }
}

