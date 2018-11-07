using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo[] methodInfos = typeof(Console).GetMethods();
            foreach (MethodInfo method in methodInfos)
            {
                Console.Write(method.Name);
                ParameterInfo[] parameterInfos = method.GetParameters();
                foreach (ParameterInfo parameter in parameterInfos)
                {
                    Console.Write(parameter.ParameterType + " : " + parameter.Name + ", ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}


