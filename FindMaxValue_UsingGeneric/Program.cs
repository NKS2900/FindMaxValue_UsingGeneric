using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue_UsingGeneric
{
    public class Program
    {      
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Find_MaxValue_UsingGenerics");          
            int value=MaximumNumberCheck.MaximumIntegerNumber(10,12,13);
            Console.WriteLine(value);
        }
    }
}
