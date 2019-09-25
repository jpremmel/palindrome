using System;
public class PalindromeChecker
{
  public bool IsPalindrome;
  public PalindromeChecker()
  {
    IsPalindrome = false;
  }
  public static void Main()
  {
    PalindromeChecker game = new PalindromeChecker();
    Console.WriteLine("Enter a phrase to see if it's a palindrome:");
    string input = Console.ReadLine();
    int distanceFromCenter = 0;
    game.CheckPalindrome(game, input, distanceFromCenter);
    if (game.IsPalindrome)
    {
      Console.WriteLine("Your phrase is a palindrome!");
      game.offerNewGame();
    }
    else
    {
      Console.WriteLine("Your phrase is not a palindrome.");
      game.offerNewGame();
    }
  }
  public void offerNewGame()
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
   
  public void CheckPalindrome(PalindromeChecker game, string input, int distanceFromCenter)
  {
    int halfway = input.Length / 2;
    if (input.Length % 2 == 0) //EVEN LENGTH INPUT
    {
      if (distanceFromCenter == halfway && distanceFromCenter != 0)
      {
        game.IsPalindrome = true;
      }
      else if(input[halfway + distanceFromCenter] == input[halfway - 1 - distanceFromCenter] && distanceFromCenter < halfway)
      {
        distanceFromCenter++;
        game.CheckPalindrome(game, input, distanceFromCenter);
      }
    }
    else if (input.Length % 2 == 1) //ODD LENGTH INPUT
    {
      if (input[halfway + distanceFromCenter] == input[halfway - distanceFromCenter] && distanceFromCenter < halfway)
      {
        distanceFromCenter++;
        game.CheckPalindrome(game, input, distanceFromCenter);
      }
      else if (distanceFromCenter == halfway && distanceFromCenter != 0)
      {
        game.IsPalindrome = true;
      }
    }
  }
}
