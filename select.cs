public class sorted {
    public string SortSentence(string s) {

        var words=s.Split(' ');
        var sorted=words.OrderBy(p=>p.First(char.IsDigit));
        var result=string.Join(" ",sorted.Select(p=>new string (p.Where(char.IsLetter).ToArray())));
        return result;
        
    }
    static void main(){
        soted sor =new sorted();
        Console.WriteLine(sor.SortSentence("is2 sentence4 This1 a3"));
    }
}