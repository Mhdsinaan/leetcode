public class Solution {
    public int HammingWeight(int n) {

       string binary=Convert.ToString(n,2);
        int countofone = binary.Count(c => c == '1');
        return countofone;

        
    }
}