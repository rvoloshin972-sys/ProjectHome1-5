using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome4
{
    public class FileManager
    {
        private FileReverser reverser = new FileReverser();
        public void ReverseFile(string filePath)
        {
            string text = File.ReadAllText(filePath);
            string reversedText = reverser.ReverseText(text);
            string directory = Path.GetDirectoryName(filePath) ?? "";
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            string newFilePath = Path.Combine(directory,fileName + "_Reversed" + extension);

            File.WriteAllText(newFilePath, reversedText);
            Console.WriteLine("\nФайл успішно перевернуто!");
            Console.WriteLine("Новий файл: " + newFilePath);
            Console.WriteLine("Кількість символів: " + text.Length);
        }
    }
}
