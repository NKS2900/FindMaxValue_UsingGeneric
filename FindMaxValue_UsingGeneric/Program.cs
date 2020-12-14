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
            double floatValue = MaximumNumberCheck.MaximumFloatNumber(55.5, 22.2, 33.3);
            Console.WriteLine(floatValue);
            string stringValue = MaximumNumberCheck.MaximumString("Apple","Banana","Peach");
            Console.WriteLine(stringValue);


        }
    }
}
