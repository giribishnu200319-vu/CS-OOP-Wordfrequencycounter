using System;
using System.IO;

namespace WordFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the folder path: ");
            string? folderPath = Console.ReadLine();

            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {   
                Console.WriteLine("Folder not found!");
                return;
            }

            FileReader reader = new FileReader(folderPath);
            string[] files = reader.GetAllTxtFiles();

            if (files.Length == 0)
            {
                Console.WriteLine("No .txt files found.");
                return;
            }

            Console.WriteLine("\nFound " + files.Length + " file(s).\n");

            WordSplitter splitter = new WordSplitter();
            WordCounter counter = new WordCounter();

            foreach (string file in files)
            {
                Console.WriteLine("Reading: " + Path.GetFileName(file));
                string content = reader.ReadFile(file);
                string[] words = splitter.SplitIntoWords(content);
                counter.CountWords(words);
            }

            ResultPrinter printer = new ResultPrinter();
            printer.PrintResults(counter.GetWordCounts());
        }
    }
}