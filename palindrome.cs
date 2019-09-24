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
    Console.WriteLine("Welcome to the palindrome checker!");
    Console.WriteLine("Enter a phrase to check:");
    string input = Console.ReadLine();
    int distanceFromCenter = 0;
    game.CheckPalindrome(game, input, distanceFromCenter);
    if (game.IsPalindrome)
    {
      Console.WriteLine("Your phrase is a palindrome!");
    }
    else
    {
      Console.WriteLine("Your phrase is not a palindrome.");
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
   public void CheckPalindrome(PalindromeChecker game, string input, int distanceFromCenter)
  {
    bool isPalindrome = false;
    int halfway = input.Length / 2;
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
