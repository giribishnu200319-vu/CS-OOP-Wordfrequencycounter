using System.Collections.Generic;

namespace WordFrequencyCounter
{
    class WordCounter
    {
        private Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        public void CountWords(string[] words)
        {
            foreach (string word in words)
            {
                string cleanWord = word.Trim('.', ',', '!', '?', ':', ';', '"', '\'').ToLower();

                if (cleanWord == "") continue;

                if (wordCounts.ContainsKey(cleanWord))
                {
                    wordCounts[cleanWord]++;
                }
                else
                {
                    wordCounts[cleanWord] = 1;
                }
            }
        }

        public Dictionary<string, int> GetWordCounts()
        {
            return wordCounts;
        }
    }
}