public class Solution {
    public void ReverseString(char[] s) {
        int rev_i;
        for (int i=0; i < s.Length/2; i++) {
            
            // get elements
            char index_char = s[i];
            //Console.Writeline("i:" + i);

            rev_i = s.Length-i-1;
            //Console.Writeline("rev_i:" + i);
            char reverse_char = s[rev_i];
            
            // 
            s[i] = reverse_char;
            s[rev_i] = index_char;
        }
    }
}
