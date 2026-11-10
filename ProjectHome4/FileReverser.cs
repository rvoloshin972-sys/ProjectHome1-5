using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome4
{
    public class FileReverser
    {
        public string ReverseText(string text)
        {
            return new string(text.Reverse().ToArray());
        }
    }
}
