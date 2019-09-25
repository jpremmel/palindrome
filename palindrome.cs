//BACK-END CODE

using System;

namespace Games
{
  class PalindromeChecker
  {
    private bool _isPalindrome;
    
    public PalindromeChecker()
    {
      _isPalindrome = false;
    }

    public bool GetIsPalindrome()
    {
      return _isPalindrome;
    }

    public void SetIsPalindrome(bool isPalindrome)
    {
      _isPalindrome = isPalindrome;
    }

    public void CheckPalindrome(string input, int distanceFromCenter)
    {
      int halfway = input.Length / 2;
      if (input.Length % 2 == 0) //EVEN LENGTH INPUT
      {
        if (distanceFromCenter == halfway && distanceFromCenter != 0)
        {
          _isPalindrome = true;
        }
        else if(input[halfway + distanceFromCenter] == input[halfway - 1 - distanceFromCenter] && distanceFromCenter < halfway)
        {
          distanceFromCenter++;
          CheckPalindrome(input, distanceFromCenter);
        }
      }
      else if (input.Length % 2 == 1) //ODD LENGTH INPUT
      {
        if (input[halfway + distanceFromCenter] == input[halfway - distanceFromCenter] && distanceFromCenter < halfway)
        {
          distanceFromCenter++;
          CheckPalindrome(input, distanceFromCenter);
        }
        else if (distanceFromCenter == halfway && distanceFromCenter != 0)
        {
          _isPalindrome = true;
        }
      }
    }
  }
}




