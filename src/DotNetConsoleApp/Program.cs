using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyMethodsWrapper;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling methods from Mylib.DLL");
            long num1 = 2;
            long num2 = 3;
            long sum = AddWrapperClass.Add(num1, num2);
            Console.WriteLine("2+3={0}", sum);

        }
    }
}
