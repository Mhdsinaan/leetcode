public class Solution {
    public bool IsPerfectSquare(int num) {
        int sqrt=(int)Math.Sqrt(num);
                      
        return sqrt*sqrt==num;
        
    }
    static void Main(){
        Solution solution = new Solution();
        Console.WriteLine(solution.IsPerfectSquare(16));
        Console.WriteLine(solution.IsPerfectSquare(14));
        

    }
}