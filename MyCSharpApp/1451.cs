using System;
using System.Linq;

public class Solution
{
    public string ArrangeWords(string text)
    {
        
        var words = text.Split(' ');

       
        words[0] = words[0].ToLower();

        
        var arrangedWords = words
            .Select((word, index) => new { word, index })
            .OrderBy(p => p.word.Length)
            .ThenBy(p => p.index)
            .Select(p => p.word)
            .ToList();

        
        arrangedWords[0] = char.ToUpper(arrangedWords[0][0]) + arrangedWords[0].Substring(1);

       
        return string.Join(" ", arrangedWords);
    }
}

public class Program
{
    public static void Main()
    {
        Solution sol = new Solution();

        string input = "Keep calm and code on";
        string result = sol.ArrangeWords(input);

        Console.WriteLine(result); 
    }
}
