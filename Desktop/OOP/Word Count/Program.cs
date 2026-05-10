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
            // ── Get N and M from user ────────────────────────
            Console.Write("Enter N (min word length to trim): ");
            string? inputN = Console.ReadLine();
            if (!int.TryParse(inputN, out int n))
            {
                Console.WriteLine("Invalid input for N.");
                return;
            }
 
            Console.Write("Enter M (characters to remove from end): ");
            string? inputM = Console.ReadLine();
            if (!int.TryParse(inputM, out int m))
            {
                Console.WriteLine("Invalid input for M.");
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

            TextProcessor processor = new TextProcessor(n, m);
            // WordSplitter splitter = new WordSplitter();
            WordCounter counter = new WordCounter();

            foreach (string file in files)
            {
                Console.WriteLine("Reading: " + Path.GetFileName(file));
                string content = reader.ReadFile(file);
                // string[] words = splitter.SplitIntoWords(content);
                var words = processor.GetProcessedWords(content);
                counter.CountWords(words.ToArray());
            }

            ResultPrinter printer = new ResultPrinter();
            printer.PrintResults(counter.GetWordCounts());
        }
    }

}