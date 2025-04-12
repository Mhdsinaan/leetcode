using System;
using System.Collections.Generic;
public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>(nums1);

        foreach (int num in nums2) {
            if (set.Contains(num)) {
                return num; 
            }
        }

        return -1; 
    }
}
public class data{
    static void Main(){
        int[] nums1={2,3,4,5};
        int [] nums2={1,3,2,7};

        Solution sol=new Solution();
        int result=sol.GetCommon(nums1,nums2);
        Console.WriteLine("smallest value"+result);
    }
}
