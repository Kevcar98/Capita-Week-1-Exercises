using System;
using static System.Net.Mime.MediaTypeNames;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean palin = false;
            Console.WriteLine("Write a word: ");
            String text=Console.ReadLine();
            char[] charArr = text.ToCharArray();
            Array.Reverse(charArr);
            String Ntext = String.Join("", charArr);

            if (Ntext == text)
            {
                palin = true;
            }

            if (palin)
            {
                Console.WriteLine("Input: "+text+ ", output: Palindrome");
            }
            else
            {
                Console.WriteLine("Input: " + text + ", output: Not Palindrome");
            }

        }
    }
}