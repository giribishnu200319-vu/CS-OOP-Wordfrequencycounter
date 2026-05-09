using System;
using System.Collections.Generic;
 
namespace WordFrequencyCounter
{
    // Responsible for displaying results on the screen
    class ResultPrinter
    {
        public void PrintResults(Dictionary<string, int> wordCounts)
        {
            Console.WriteLine("\n===== WORD FREQUENCY RESULTS =====\n");
            Console.WriteLine("{0,-20} {1}", "WORD", "COUNT");
            Console.WriteLine(new string('-', 30));
 
            foreach (KeyValuePair<string, int> entry in wordCounts)
            {
                Console.WriteLine("{0,-20} {1}", entry.Key, entry.Value);
            }
 
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Total unique words: " + wordCounts.Count);
        }
    }
}