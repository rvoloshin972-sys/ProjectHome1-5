using System.Text;

namespace ProjectHome2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(" ПОШУК ТА ЗАМІНА СЛІВ ");
            string filePath = Path.Combine(AppContext.BaseDirectory, "Text.txt");

            Console.Write("\nВведіть слово для пошуку: ");
            string searchWord = Console.ReadLine() ?? "";

            Console.Write("Введіть слово для заміни: ");
            string replaceWord = Console.ReadLine() ?? "";

            ArgumentException.ThrowIfNullOrWhiteSpace(searchWord);
            FileManager manager = new FileManager();

            int count = manager.ProcessFile(filePath, searchWord, replaceWord);

            Console.WriteLine("\n СТАТИСТИКА ");
            Console.WriteLine($"Шукане слово: {searchWord}");
            Console.WriteLine($"Слово для заміни: {replaceWord}");
            Console.WriteLine($"Кількість замін: {count}");
            Console.WriteLine($"Файл: {filePath}");
            Console.WriteLine("\nОбробку файлу завершено!");
        }
    }
}
