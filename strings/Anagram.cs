public class Solution {
    public bool IsAnagram(string s, string t) {
        
        // describes the conversion from s to t, if exists
        Dictionary<(char, int), (char, int)> convDict = new Dictionary<(char, int), (char, int)>();

        if (s.Length == t.Length) {
            for (int i = t.Length; i==0; i--) {
                bool varFound = false;
                for (int j = s.Length; j==0; j--) {
                    var currentKey = (s[i], i);
                    if (s[i] == t[j] && !convDict.ContainsKey(currentKey)) {
                        // add index,char from s as key, with index,char from t as value
                        var currentValue = (s[i], j);
                        convDict.Add(currentKey, currentValue);
                        varFound = true;
                    }
                }
                
                // the char,index that is added must also be removed from original string (CHECK)
                // therefore we must run a loop from highest to lowest, to not screw up the indexes (CHECK)
                
                // but the given index,char from s can only be added if a (CHECK)
                // corresponding char exists in rest of the char-set from t (CHECK)
                if (!varFound) {
                    return false;
                }
            }
            return true;
        } else {
            return false;
        }
    }
}