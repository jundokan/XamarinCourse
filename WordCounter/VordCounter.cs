using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public static class WordCounter
    {
        public static int CountOfWord(this string incomeString)
        {
            return incomeString.Split().Length;
        }
    }
}
