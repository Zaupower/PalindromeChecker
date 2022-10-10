
class Program
{
    static void Main(string[] args)
    {
        string word = "";
        
        Console.WriteLine("Please input word");
        word = Console.ReadLine();

        bool isPalindrome =  ispalidrome(word);
        Console.WriteLine(word + (isPalindrome == true ? " IS" : " IS NOT") + " palidrome");

    }

    public static bool ispalidrome(String word)
    {
        char[] wordCharacters = word.ToCharArray();
        for (int i = 0; i < wordCharacters.Length ; i++)
        {
            if (wordCharacters[i] != wordCharacters[ (wordCharacters.Length -1 ) - i] )
            {
                return false;
            }
        }
        return true;
    }
}