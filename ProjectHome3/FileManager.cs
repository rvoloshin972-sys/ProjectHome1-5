using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome3
{
    public class FileManager
    {
        private Moderator moderator = new Moderator();
        public void ModerateFile(string textPath, string wordsPath)
        {
            string text = File.ReadAllText(textPath);
            string wordsText = File.ReadAllText(wordsPath);
            string[] words = wordsText.Split((char[]?)null,StringSplitOptions.RemoveEmptyEntries);

            string result = moderator.ModerateText(text, words);
            string directory = Path.GetDirectoryName(textPath) ?? "";
            string resultPath = Path.Combine(directory, "Moderated.txt");

            File.WriteAllText(resultPath, result);
            Console.WriteLine("\nМодерацію успішно завершено!");
            Console.WriteLine("Початковий файл: " + textPath);
            Console.WriteLine("Файл зі словами: " + wordsPath);
            Console.WriteLine("Результат: " + resultPath);
            Console.WriteLine("Кількість слів для модерації: " + words.Length);
        }
    }
}
