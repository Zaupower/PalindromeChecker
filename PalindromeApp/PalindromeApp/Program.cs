
class Program
{
    static void Main(string[] args)
    {
        string word = "";
        
        Console.WriteLine("Please input word");
        word = Console.ReadLine();
        char[] wordCharacters = word.ToCharArray();
        
        //Print char array
        for (int i = 0; i < wordCharacters.Length ; i++)
        {
            Console.Write("from start: "); 
            Console.Write(wordCharacters[i] + " "); 
            
            Console.Write(" ; from end: ");
            Console.Write(wordCharacters[ (wordCharacters.Length -1 ) - i] + " "); 
            
            Console.WriteLine("");
        }
    }
}