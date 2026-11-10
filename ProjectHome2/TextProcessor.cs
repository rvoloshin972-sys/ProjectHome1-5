using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome2
{
    public class TextProcessor
    {
        public int ReplacementCount { get; private set; }
        public string ReplaceWord(string line, string searchWord,string replaceWord)
        {
            ReplacementCount += line.Split(new string[] { searchWord },StringSplitOptions.None).Length - 1;
            return line.Replace(searchWord, replaceWord);
        }
    }
}
