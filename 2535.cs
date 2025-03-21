public class Solution {
    public int DifferenceOfSum(int[] nums) {

        int sumofDigits=nums.Sum();
        int values=nums.Select(p=>p.ToString().Sum(num=>num-'0')).Sum();

        return Math.Abs(sumofDigits-values);
        
    }
    static void Main(){
         int[] nums1 = { 1, 15, 6, 3 };
        Console.WriteLine(DifferenceOfSum(nums1));
    }
}
