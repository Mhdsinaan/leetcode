public class mark
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        foreach(char ch in letters) // letters array loop cheyyunnu
        {
            if(ch > target)         // target nekkal valiya letter kittiyal
                return ch;          // ath return cheyyu
        }

        return letters[0]; // ellam target nekkal valuthallaengil wrap-around cheythu letters[0] return cheyyu
    }

    static void Main()
    {
        mark m = new mark();
        Console.WriteLine(m.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'c')); // Output: f
    }
}
