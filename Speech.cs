using System.Security.Cryptography.X509Certificates;

namespace knightmoves;
public class Speech
{   
    public const string Quote = "...ask not what your country can do for you — ask what you can do for your country.";

    public static int Length = Quote.Length; 
    public char TwentySecondLetter = Quote[23];

    public string PrintLengthAndTwentySecondLetter(){

    string printLengthAndTwentySecondLetter = "length: {Length} and 22nd: {TwentySecondLetter}";


        return printLengthAndTwentySecondLetter;
    }
}
