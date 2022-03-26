using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Hi!";
            UnicodeEncoding unicode = new UnicodeEncoding();
            var result = unicode.GetBytes(text);
            Console.WriteLine(string.Join("",result));

        }
    }
}
