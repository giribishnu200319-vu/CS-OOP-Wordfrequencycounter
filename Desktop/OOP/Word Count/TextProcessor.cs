using System;
using System.Collections.Generic;
 
namespace WordFrequencyCounter
{
    // Responsible for:
    // 1. Splitting text into words (by whitespace AND punctuation)
    // 2. Converting to lowercase
    // 3. Removing last M characters if word length > N
    class TextProcessor
    {
        private int n; // minimum length before trimming
        private int m; // how many characters to remove from the end
 
        public TextProcessor(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
 
        public List<string> GetProcessedWords(string text)
        {
            List<string> result = new List<string>();
 
            // Split by whitespace AND punctuation
            char[] separators = new char[]
            {
                ' ', '\t', '\n', '\r',
                '.', ',', '!', '?', ':', ';',
                '"', '\'', '(', ')', '-', '/'
            };
 
            string[] rawWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
 
            foreach (string raw in rawWords)
            {
                // Step 1: lowercase
                string word = raw.ToLower();
 
                // Step 2: ignore empty entries
                if (word == "") continue;
 
                // Step 3: if length > N, remove last M characters
                if (word.Length > n)
                {
                    word = word.Substring(0, word.Length - m);
                }
 
                // Step 4: skip if trimming made it empty
                if (word == "") continue;
 
                result.Add(word);
            }
 
            return result;
        }
    }
}