using System;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the palindrome checker!");
    Console.WriteLine("Enter a phrase to check:");
    string input = Console.ReadLine();
    int distanceFromCenter = 0;
    bool isPalindrome = CheckPalindrome(input, distanceFromCenter);
    if (isPalindrome)
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
  static bool CheckPalindrome(string input, int distanceFromCenter)
  {
    bool isPalindrome = false;
    int halfway = input.Length / 2;
    if (input[halfway + distanceFromCenter] == input[halfway - distanceFromCenter] && distanceFromCenter < halfway)
    {
      distanceFromCenter++;
      CheckPalindrome(input, distanceFromCenter);
    }
    else if (distanceFromCenter == halfway)
    {
      isPalindrome = true;
    }
    return isPalindrome;
  }
}
