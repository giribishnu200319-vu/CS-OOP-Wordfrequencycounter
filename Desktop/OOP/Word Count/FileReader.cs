using System.IO;
 
namespace WordFrequencyCounter
{
    // Responsible for finding and reading .txt files from a folder
    class FileReader
    {
        private string folderPath;
 
        public FileReader(string path)
        {
            folderPath = path;
        }
 
        public string[] GetAllTxtFiles()
        {
            return Directory.GetFiles(folderPath, "*.txt");
        }
 
        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}