using System;
using System.Collections.Generic;
using System.IO;

public static class LoadingDictionary
{
    public static Dictionary<string, string> LoadDictionary(string filePath)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('-');
                if (parts.Length == 2)
                {
                    dictionary[parts[0].ToLower()] = parts[1].ToLower();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading the dictionary file: " + ex.Message);
        }

        return dictionary;
    }
}