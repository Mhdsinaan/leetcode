public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int ones = 0;
        int zeros = 0;

        foreach (char c in s) {
            if (c == '1') ones++;
            else zeros++;
        }

        return new string('1', ones - 1) + new string('0', zeros) + '1';
    }
}
