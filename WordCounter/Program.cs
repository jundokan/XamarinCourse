using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is my string";
            int result = str.CountOfWord();

            Console.WriteLine("u = {0}", result );
            Console.Read();
        }
    }
}
