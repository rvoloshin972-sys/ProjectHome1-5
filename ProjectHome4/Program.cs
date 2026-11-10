using System.IO;
using System.Text;

namespace ProjectHome4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("ПЕРЕВЕРТАННЯ ВМІСТУ ФАЙЛУ");
            Console.WriteLine();

            Console.Write("Введіть шлях до файлу: ");
            string inputPath = Console.ReadLine() ?? "";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..", "..", "..",inputPath);
            filePath = Path.GetFullPath(filePath);
            FileManager manager = new FileManager();

            try
            {
                manager.ReverseFile(filePath);
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
