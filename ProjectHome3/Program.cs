using System;
using System.IO;
using System.Text;

namespace ProjectHome3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("ДОДАТОК МОДЕРАТОР");
            Console.WriteLine();

            Console.Write("Введіть шлях до текстового файлу: ");
            string textPath = Console.ReadLine() ?? "";

            Console.Write("Введіть шлях до файлу зі словами: ");
            string wordsPath = Console.ReadLine() ?? "";

            string basePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..", "..", ".."));

            textPath = Path.GetFullPath
            (
                Path.IsPathRooted(textPath)
                    ? textPath
                    : Path.Combine(basePath, textPath)
            );

            wordsPath = Path.GetFullPath
            (
                Path.IsPathRooted(wordsPath)
                    ? wordsPath
                    : Path.Combine(basePath, wordsPath)
            );
            FileManager manager = new FileManager();

            try
            {
                manager.ModerateFile(textPath, wordsPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
            Console.WriteLine("\nНатисніть Enter для завершення...");
            Console.ReadLine();
        }
    }
}
