using System;
using System.Diagnostics.Tracing;
using System.Text;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            //save the cleaned user input in a variable
            string word = CleanString(UserInput());
            //display the appropriate message to the user
            Console.WriteLine(IsPalindrome(word) ? "That is a palindrome." : "That is not a palindrome.");
        }

        //method to prompt the user for a string word or phrase
        static string UserInput()
        {
            Console.Write("Enter a string to see if it's a palindrome: ");
            return Console.ReadLine();
        }

        //method to clean the string of whitespace, capitalization, and punctuation
        static string CleanString(string word)
        {
            //convert the phrase to lower case
            string wordToLower = word.ToLower();
            //remove whitespace from the lower case string
            string noWhiteSpace = wordToLower.Replace(" ", "");
            //create a StringBuilder variable to hold the new string with punctuation removed
            StringBuilder cleanedWord = new StringBuilder();
            //for loop to iterate through the noWhiteSpace/lower case string
            foreach (char c in noWhiteSpace)
            {
                //if the char is not punc append it to the cleanedWord string
                if (!Char.IsPunctuation(c))
                {
                    cleanedWord.Append(c);
                }
            }
            //return the cleaned word
            return cleanedWord.ToString();
        }
        //recursive method to check is the cleaned string is a palendrome
        static bool IsPalindrome(string word)
        {
            //if the cleaned word is empty or one char long return true
            if (word == "" || word.Length == 1) return true;
            // else use recursion to call the method on increasingly smaller substrings until the method returns a bool
            if (word[0] == word[^1])
            {
                //call method with substring from index 1 to the second to last index
                return IsPalindrome(word.Substring( 1, word.Length - 2));
            }

            return false;
        }
    }
}

