public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length == t.Length) {
            // initialize dictionary
            // add index,char from s as key, with index,char from t as value
            // the char,index that is added must also be removed from original string
            // therefore we must run a loop from highest to lowest, to not screw up the indexes
            
            // but the given index,char from s can only be added if a
            // corresponding char exists in rest of the char-set from t
            
            
            return true;
        } else {
            return false;
        }
    }
}