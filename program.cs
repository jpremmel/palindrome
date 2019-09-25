//FRONT END CODE
using System;
using Games;

public class PalindromeProgram
{
  public static void Main()
  {
    PalindromeChecker game = new PalindromeChecker();
    Console.WriteLine("Enter a phrase to see if it's a palindrome:");
    string input = Console.ReadLine();
    int distanceFromCenter = 0;
    game.CheckPalindrome(input, distanceFromCenter);
    if (game.GetIsPalindrome())
    {
      Console.WriteLine("Your phrase is a palindrome!");
      OfferNewGame();
    }
    else
    {
      Console.WriteLine("Your phrase is not a palindrome.");
      OfferNewGame();
    }
  }

  public static void OfferNewGame()
  {
    Console.WriteLine("Want to check another phrase? (Enter Y / N)");
    string newGame = Console.ReadLine();
    if (newGame[0].ToString().ToUpper() == "Y")
    {
      Main();
    }
    else
    {
      Console.WriteLine("Goodbye.");
    }
  }

}