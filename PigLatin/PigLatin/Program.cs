using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            PrintColorMessage(ConsoleColor.Yellow, "******************PIGLATIN TRANSLATE******************");
            GetAppInfo();
            Console.WriteLine();
            CallRetrieveWordInPigLatin();
            Console.ReadLine();
        }

        

         static string RetrieveWordInPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeio";
            var returnSentence = "";
            foreach (var word in sentence.Split())
            {
                var firstLetter = word.Substring(0, 1);
                var restOfWord = word.Substring(1, word.Length - 1);
                var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }
                else
                {
                    returnSentence += word + "way ";
                }
            }
            return returnSentence;
            
        }
      

        static void CallRetrieveWordInPigLatin()
        {
            
            PrintColorMessage(ConsoleColor.DarkCyan, "Enter a sentence to convert to PigLatin:");
            string sentence = Console.ReadLine();
            var pigLatin = RetrieveWordInPigLatin(sentence);
            PrintColorMessage(ConsoleColor.Yellow, pigLatin);

            //---------------**CONVERT PIG LATIN TO ENGLISH**---------------------------//
            PrintColorMessage(ConsoleColor.DarkCyan, "Press Enter to flip the sentence back.");
            Console.ReadKey(true);
            string clonedString = null;
            clonedString = (String)sentence.Clone();
            PrintColorMessage(ConsoleColor.Yellow, clonedString);
            Console.ReadLine();

        }
       


        //Get and display app Info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "kendrck";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }


        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //tell user it is the wrong number
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }


    }
}
