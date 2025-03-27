using System;
public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
      int left=0;
      int right=0;
      int underScore=0;

      foreach(var move in moves){
        if(move=='L') left ++;
        else if(move=='R') right++;
        else if(move=='_') underScore++;

      }
       return Math.Abs(left - right) + underScore;
    }
    static void Main()
    {
      Solution Sol=new Solution();
     
      Console.WriteLine(Sol.FurthestDistanceFromOrigin("L_RL__R"));
    }
}