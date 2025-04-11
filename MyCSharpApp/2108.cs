using System;
using System.Linq;

public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (string word in words) {
            if (IsPalindrome(word)) {
                return word;
            }
        }
        return "";
    }

    private bool IsPalindrome(string word) {
        return word.SequenceEqual(word.Reverse());
    }
}

public class Program {
    public static void Main(string[] args) {
        Solution solu = new Solution();

        string[] words = { "abc", "car", "ada", "racecar", "cool" };
        string result = solu.FirstPalindrome(words);

        Console.WriteLine("First Palindromic Word: " + result);
    }
}
