using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome1
{
    public class FileManager
    {
        private string folderPath = AppContext.BaseDirectory;
        public void SaveNumbers(string fileName, List<int> numbers)
        {
            string filePath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
            Console.WriteLine($"Файл {fileName} збережено.");
        }
        public void ReadNumbers(string fileName)
        {
            string filePath = Path.Combine(folderPath, fileName);
            Console.WriteLine($"\nВміст файлу {fileName}:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.Write(line + " ");
                }
            }
            Console.WriteLine();
        }
    } 
}
