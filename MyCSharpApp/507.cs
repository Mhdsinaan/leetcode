// public class Solution {
//     public bool CheckPerfectNumber(int num) {

//          if (num <= 1)
//             return false;

//         int sum = 0;

//         for (int i = 1; i <= num / 2; i++)
//         {
//             if (num % i == 0) 
//                 sum += i;
//         }

//         return sum == num;
    

        
//     }
//     static void Main(){
//         Solution sol=new Solution();
//         Console.WriteLine(sol.CheckPerfectNumber(9));
//     }
// }