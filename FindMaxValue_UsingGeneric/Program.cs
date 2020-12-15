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
            int value=MaximumNumberCheck.findMaximum(10,11,12);
            Console.WriteLine(value);
            Console.WriteLine("==========");
            double floatValue = MaximumNumberCheck.findMaximum(55.5, 22.2, 33.3);
            Console.WriteLine(floatValue);
            Console.WriteLine("==========");
            string stringValue = MaximumNumberCheck.findMaximum("Apple","Banana","Peach");
            Console.WriteLine(stringValue);
            Console.WriteLine("==========");
            int[] arr = { 12, 45, 41, 22, 66 };
            GenricMaximum<int> generic = new GenricMaximum<int>(arr);
        }
    }
}
