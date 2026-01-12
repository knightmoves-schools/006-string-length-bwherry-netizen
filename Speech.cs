using System.Security.Cryptography.X509Certificates;

namespace knightmoves;

public class Speech
{
    public const string Quote = "...ask not what your country can do for you — ask what you can do for your country.";

    public int Length = Quote.Length;

    public string PrintLengthAndTwentySecondLetter()
    {

        char TwentySecondLetter = Quote[23];

        return $"{TwentySecondLetter}";

    }
}