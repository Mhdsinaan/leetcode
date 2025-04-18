public class mark
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        foreach(char ch in letters)
        {
            if(ch > target)         
                return ch;          
        }

        return letters[0]; 
    }

    static void Main()
    {
        mark m = new mark();
        Console.WriteLine(m.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'c')); 
    }
}
