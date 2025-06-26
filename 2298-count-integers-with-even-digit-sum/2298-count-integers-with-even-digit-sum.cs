public class Solution {
    public int CountEven(int num) {
        int count = 0;
        for (int i = 1; i <= num; i++) {
            if (get(i) % 2 == 0) {   
                count++;
            }
        }
        return count;
    }

    private int get(int n) {
        int sum = 0;
        while (n > 0) {
            sum += n % 10;   
            n /= 10;         
        }
        return sum;
    }
}
