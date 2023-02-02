using System.Diagnostics;
using System.IO;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            String Aword = "star";
            String[] words = { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };

            for (int i = 0;i< words.Length; i++)
            {
                if (words[i].Length == Aword.Length)
                {

                    if (words[i].IndexOf("s")==-1)//if the sting in array position i doesn't havve the letter s
                    {
                    }
                    else if (words[i].IndexOf("t") == -1)
                    {
                    }
                    else if (words[i].IndexOf("a") == -1)
                    {
                    }
                    else if (words[i].IndexOf("r") == -1)
                    {
                    }
                    else
                    {
                        Console.WriteLine(words[i]);
                    }

                }
            }
        }
    }
}