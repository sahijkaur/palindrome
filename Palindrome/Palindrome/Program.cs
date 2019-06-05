using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PlayWithPalindromes();
            Console.WriteLine(p.Kagaroo());
        }
    }

    class PlayWithPalindromes
    {
        static string YouWin = "You Win!";
        public string Kagaroo()
        {
            Console.WriteLine("want to play a game?");
            Console.WriteLine("enter a word");
            string Word1 = Console.ReadLine();
            Console.WriteLine("enter another word");
            string Word2 = Console.ReadLine();

            // parse each word and enter it
            // letter by letter into an ARRAY

            string[] WordOneArray = new string[5];
            string[] WordTwoArray = new string[5];

            for (int i = 0; i < Word1.Length; i++)
            {
                WordOneArray[i] = Word1.Substring(i, 1);
            }

            for (int i = 0; i < Word2.Length; i++)
            {
                WordTwoArray[i] = Word2.Substring(i, 1);
            }

            // how to compare 2 arrays?
            int z = Word2.Length;
            for (int j = 0; j < WordOneArray.Length; j++)
            {
                if (WordOneArray[j] != WordTwoArray[Word2.Length - z--])
                {
                 //   Console.WriteLine(WordOneArray[word2.length-z]);
                    YouWin = "You Lose!";
                    break;
                }
            }

            return YouWin;
        }
    }
}
