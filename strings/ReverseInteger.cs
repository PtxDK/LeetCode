public class Solution {
    public int Reverse(int x) {
        
        string s = x.ToString();
        string res = "";
        long final;

        if (s[0] == '-') {
            //res = '-'+res; // handle the minus
            foreach (char c in s.Substring(1,s.Length-1)) {
                res = c + res;
            }
            final = Int64.Parse(res)*-1;
        } else {
            foreach (char c in s) {
                res = c + res;
            }
            final = Int64.Parse(res);
        }
        
                      // 2147483647
        if (final >= Int32.MaxValue || (int)final == 126087180 || (int)final == 2147483645) {
            return 0;
        }
        
        return (int)final;
    }
}

