using Xunit;
using PalindromeApp.Objects;
using System;
using System.Collections.Generic;

namespace PalindromeApp
{
    public class PalindromeTest
    {
    //Test to see if the user's word is reversed by our program
        [Fact]
        public void ReverseInput_ReverseUserInput_String()
        {
            //arrange
            string word = "cat";
            string reverseWord = "tac";
            Palindrome newPalindrome = new Palindrome(word);
            //act
            string result = newPalindrome.ReverseInput();
            //assert
            Assert.Equal(reverseWord, result);
        }
    //Test to see if the user's word is a palindrom after it is reversed by our program
            [Fact]
            public void IsPalindrome_ReturnTrueifPalidrome_True()
            {
                //arrange
                string word = "racecar";
                bool desiredResult = true;
                Palindrome newPalindrome = new Palindrome(word);
                //act
                bool result = newPalindrome.IsPalindrome();
                //assert
                Assert.Equal(desiredResult, result);
            }
    }
}
