using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome5
{
    public class NumberAnalyzer
    {
        public NumberStatistics AnalyzeFile(string filePath)
        {
            NumberStatistics statistics = new NumberStatistics();

            string directory = Path.GetDirectoryName(filePath) ?? "";
            string positivePath = Path.Combine(directory, "Positive.txt");
            string negativePath = Path.Combine(directory, "Negative.txt");
            string twoDigitPath = Path.Combine(directory, "TwoDigit.txt");
            string fiveDigitPath = Path.Combine(directory, "FiveDigit.txt");

            using StreamReader reader = new StreamReader(filePath);
            using StreamWriter positiveWriter = new StreamWriter(positivePath);
            using StreamWriter negativeWriter = new StreamWriter(negativePath);
            using StreamWriter twoDigitWriter = new StreamWriter(twoDigitPath);
            using StreamWriter fiveDigitWriter = new StreamWriter(fiveDigitPath);

            string content = reader.ReadToEnd();
            string[] numbers = content.Split((char[]?)null,StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in numbers)
            {
                int number = int.Parse(item);
                long absoluteNumber = Math.Abs((long)number);

                statistics.PositiveCount += number > 0 ? 1 : 0;
                statistics.NegativeCount += number < 0 ? 1 : 0;
                statistics.TwoDigitCount += absoluteNumber >= 10 && absoluteNumber <= 99 ? 1 : 0;
                statistics.FiveDigitCount += absoluteNumber >= 10000 && absoluteNumber <= 99999 ? 1 : 0;
                positiveWriter.Write(number > 0 ? number + Environment.NewLine : "");
                negativeWriter.Write(number < 0 ? number + Environment.NewLine : "");
                twoDigitWriter.Write(
                    absoluteNumber >= 10 && absoluteNumber <= 99
                    ? number + Environment.NewLine : ""
                );

                fiveDigitWriter.Write(
                    absoluteNumber >= 10000 && absoluteNumber <= 99999
                    ? number + Environment.NewLine : ""
                );
            }
            return statistics;
        }
    }
}