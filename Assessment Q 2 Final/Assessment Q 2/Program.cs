using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will check to see if a word is a plaindrome");
            Console.WriteLine("");
            string wordOne = prompt("Please enter the word");
            string wordTwo = wordOne;

            if(SameLengthCheck(wordOne, wordTwo) == true)
            {
                if(IsPalindrome(wordOne, wordTwo) == true)
                {
                    Console.WriteLine("Palindrome!");
                } else if (IsPalindrome(wordOne, wordTwo) == false)
                {
                    Console.WriteLine("NOT Palindrome");
                }
            }
            Console.ReadKey();
        }
        static bool IsPalindrome(string test1, string test2)
        {
            if (backwards(test1) == test2)
            {
                return true;
            }
            return false;
        }

        static string backwards(string temp)
        {
            string word ="";
            for (int i =(temp.Length -1); i>= 0; i--)
            {
                word = word + temp[i];
            }
            return word;
        }

        static bool SameLengthCheck (string temp1, string temp2)
        {
            if(temp1.Length == temp2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string prompt(string msg)
        {
            Console.WriteLine(msg + " ");
            return Console.ReadLine();
        }
    }
}
