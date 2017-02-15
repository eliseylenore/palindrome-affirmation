 using System;
  using System.Collections.Generic;

  namespace PalindromeApp.Objects
  {
      public class Palindrome
      {
          private string _userInput;
          private string _reverse;

          public Palindrome(string userInput)
          {
            _userInput = userInput;
            _reverse = "";
          }

          public string GetUserInput()
          {
              return _userInput;
          }

          public string ReverseInput()
          {

              for (var i= 1; i <= _userInput.Length; i++)
              {
                 _reverse += _userInput[_userInput.Length-i];
              }
              return _reverse;
          }

          public bool IsPalindrome()
          {
              if (_userInput == this.ReverseInput())
              {
                  return true;
              }
              else
              {
                  return false;
              }
          }
      }
  }
