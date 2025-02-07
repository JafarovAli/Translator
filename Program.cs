using System;
using System.Collections.Generic;
using System.IO;


namespace Translator
{
    class Program
    {
        static void Main()
        {
            string filePath = @"D:\C#\Translator\dictionary.txt";
            Dictionary<string, string> dictionary = LoadingDictionary.LoadDictionary(filePath);

            if (dictionary.Count == 0)
            {
                Console.WriteLine("The dictionary is empty or could not be loaded.");
                return;
            }
            Console.WriteLine("If you enter 0, program will close!");
            Console.WriteLine();
            while (true)
            {
                Random random = new Random();
                List<string> englishWords = new List<string>(dictionary.Keys);
                string selectedEnglishWord = englishWords[random.Next(englishWords.Count)];

                Console.Write($"'{selectedEnglishWord}'-");
                string userTranslation = Console.ReadLine().ToLower();

                if (userTranslation == dictionary[selectedEnglishWord])
                {
                    Console.WriteLine("Success! Your translation is correct.");
                }
                else if (userTranslation == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"The correct translation is: {dictionary[selectedEnglishWord]}");
                }
            }
        }
    }
}
