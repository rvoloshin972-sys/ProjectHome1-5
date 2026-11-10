using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome2
{
    public class FileManager
    {
        public int ProcessFile(string filePath, string searchWord,string replaceWord)
        {
            string tempPath = filePath + ".tmp";
            TextProcessor processor = new TextProcessor();
            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string newLine = processor.ReplaceWord(line, searchWord, replaceWord);
                    writer.WriteLine(newLine);
                }
            }
            File.Move(tempPath, filePath, true);
            return processor.ReplacementCount;
        }
    }
}
