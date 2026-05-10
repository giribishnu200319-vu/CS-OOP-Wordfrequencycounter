Word Frequency Counter
A C# command-line application built as part of an Object-Oriented Programming (OOP) assignment. The program reads all .txt files from a specified folder, splits the text into individual words, counts how frequently each word appears, and displays the results in a formatted table on the screen.
Version 1 — Basic Word Frequency Counter
The first version focuses on the core functionality. It is structured into four classes — FileReader, WordSplitter, WordCounter, and ResultPrinter — each responsible for a single task. The program reads all .txt files from a user-specified folder, splits the content into words, removes basic punctuation, counts each word in a case-insensitive manner using a Dictionary<string, int>, and prints the results.
Version 2 — Extended with Word Trimming
The second version extends the first by introducing a trimming rule. The user provides two values — N and M. If a word's length is greater than N, the last M characters are removed before counting. This allows words with similar roots (such as running, runner, runs) to be grouped together approximately. The WordSplitter class was replaced by a new TextProcessor class that handles splitting, lowercase conversion, punctuation removal, and the trimming logic all in one place.
Technologies Used

Language: C#
Framework: .NET 8
IDE: Visual Studio Code
Concepts: Object-Oriented Programming, Classes, Dictionary, File I/O
