using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectHome3
{
    public class Moderator
    {
        public string ModerateText(string text, string[] words)
        {
            foreach (string word in words)
            {
                string pattern = @"\b" + Regex.Escape(word) + @"\b";
                text = Regex.Replace(text,pattern,new string('*', word.Length),RegexOptions.IgnoreCase);
            }
            return text;
        }
    }
}
