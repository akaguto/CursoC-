using System;

namespace Aula88FuncoesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "demian WALKED AND looked AROUND    ";
            Console.WriteLine(original);

            //----Format----//
            Console.WriteLine("\n|---- Format----|");

            string allUpper = original.ToUpper(); 
            Console.WriteLine("\nOriginal: -" + original + "-");
            Console.WriteLine("ToUpper: -" + allUpper + "-");

            string allLower = original.ToLower();
            Console.WriteLine("\nOriginal: -" + original + "-");
            Console.WriteLine("ToLower: -" + allLower + "-");

            string whiteSpacesTrim = original.Trim();
            Console.WriteLine("\nOriginal: -" + original + "-");
            Console.WriteLine("Trim: -" + whiteSpacesTrim + "-");


            //----Search----//
            Console.WriteLine("\n|---- Search ----|");

            int searchValue = original.IndexOf("an"); //First occurrence of this parameter. (an)
            Console.WriteLine("\nIndexOf('an'): " + searchValue + " <== index.");

            int searchLastValue = original.LastIndexOf("an"); //Last occurrence of this parameter. (an)
            Console.WriteLine("\nLastIndexOf('an'): " + searchValue + " <== index.");

            //----Cut----//
            Console.WriteLine("\n|---- Cut ----|");

            string cutIndexAll = original.Substring(searchValue);
            Console.WriteLine("\nSubstring of index 4(searchValue): -" + cutIndexAll +"-");

            string cutIndexLength = original.Substring(searchValue, 5);
            Console.WriteLine("\nSubstring of index 4(searchValue) with length of 5: -" + cutIndexLength + "-");

            //----Replace----//
            Console.WriteLine("\n|---- Replace ----|");

            string textReplace = original.Replace("demian", "Lana");
            Console.WriteLine("\nReplace of word(demian => lana): -"+textReplace +"-");

            string charReplace = original.Replace('a', 'y');
            Console.WriteLine("\nReplace of char(a => y): -" + charReplace + "-");

            //----Empty string----//
            Console.WriteLine("\n|---- Empty string----|");
           
            bool fieldNullOrEmpty = String.IsNullOrEmpty(original); //test if content is null or empty
            Console.WriteLine("\nVerify if the string is null or empty: " + fieldNullOrEmpty);

            bool fieldNullOrWhiteSpace = String.IsNullOrWhiteSpace(original); //test if content is null or white spaces.
            Console.WriteLine("\nVerify if the string is null or empty: " + fieldNullOrWhiteSpace);


        }
    }
}
