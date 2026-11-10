using System;
using System.IO;
using System.Text;

namespace ProjectHome5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("СТАТИСТИКА ЦІЛИХ ЧИСЕЛ У ФАЙЛІ");
            Console.WriteLine();

            Console.Write("Введіть шлях до файлу: ");
            string inputPath = Console.ReadLine() ?? "";
            string filePath = Path.IsPathRooted(inputPath)
                ? inputPath
                : Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..", "..", "..",inputPath));
            NumberAnalyzer analyzer = new NumberAnalyzer();

            try
            {
                NumberStatistics statistics = analyzer.AnalyzeFile(filePath);
                Console.WriteLine("\nСТАТИСТИКА ФАЙЛУ");
                Console.WriteLine("");

                Console.WriteLine("Кількість додатних чисел: " +
                    statistics.PositiveCount);

                Console.WriteLine("Кількість від'ємних чисел: " +
                    statistics.NegativeCount);

                Console.WriteLine("Кількість двозначних чисел: " +
                    statistics.TwoDigitCount);

                Console.WriteLine("Кількість п'ятизначних чисел: " +
                    statistics.FiveDigitCount);

                Console.WriteLine("");
                Console.WriteLine("\nФайли успішно створено!");
                Console.WriteLine("Positive.txt");
                Console.WriteLine("Negative.txt");
                Console.WriteLine("TwoDigit.txt");
                Console.WriteLine("FiveDigit.txt");
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
