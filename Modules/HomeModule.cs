
using Nancy;
using System.Collections.Generic;
using PalindromeApp.Objects;


namespace PalindromeApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/result"] = _ => {
        string userInput = Request.Form["user-word"];
        Palindrome newPalindrome = new Palindrome(userInput);
        return View["index.cshtml", newPalindrome];
      };
    }
  }
}
