using System.Security.Cryptography.X509Certificates;

namespace knightmoves;

public class Speech
{
    public const string Quote = "...ask not what your country can do for you — ask what you can do for your country.";

    

    public string PrintLengthAndTwentySecondLetter()
    {
        int LengthOfQuote = Quote.Length;

        char TwentySecondLetter = Quote[21];

        return $"Length of Quote: {LengthOfQuote}, 22nd Letter: '{TwentySecondLetter}'";

    }
}
