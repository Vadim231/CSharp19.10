using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MyClass
    {
        public int Number { get; set; } = 0;
        public string Line { get; set; } = "";

        public MyClass(int nInt, string nString)
        {
            Number = nInt;
            Line = nString;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Number = {Number}");
            Console.WriteLine($"Line = {Line}");
        }
    }
}
