class Program
{
    static void Main(string[] args)
    {
        string word = "";

        Console.WriteLine("Please input word");
        word = Console.ReadLine();

        bool isPalindrome = Ispalidrome(word.ToLower());
        Console.WriteLine(word + " - " + (isPalindrome ? " " : " not ") + "palindrome");
    }

    public static bool Ispalidrome(String word)
    {
        bool isPalenDrome = false;

        try
        {
            int halfLength = word.Length / 2;

            string leftHalfString = word.Substring(0, halfLength);

            char[] reversedArray = word.ToCharArray();
            Array.Reverse(reversedArray);
            
            string reversedString = new string(reversedArray);

            string rightHalfStringReversed = reversedString.Substring(0, halfLength);

            isPalenDrome = leftHalfString == rightHalfStringReversed ? true : false;
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return isPalenDrome;
    }
}