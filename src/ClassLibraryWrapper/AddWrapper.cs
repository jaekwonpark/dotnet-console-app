using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMethods;

namespace MyMethodsWrapper
{
    public class AddWrapperClass
    {
        public static long Add(long i, long j)
        {
            Console.WriteLine("I'm Wrapper, calling Add");
            long result = AddClass.Add(i,j);
            return result;
        }
    }
}
