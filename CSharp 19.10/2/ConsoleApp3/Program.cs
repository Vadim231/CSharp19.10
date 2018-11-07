using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1, "Text");
            myClass.ShowInfo();
            Console.WriteLine("\nРефлексия");
            FieldInfo[] fieldInfos = (myClass.GetType()).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo field in fieldInfos)
            {
                Console.WriteLine(field.Name + "\t" + field.FieldType);
            }
            Console.ReadLine();
        }
    }
}
