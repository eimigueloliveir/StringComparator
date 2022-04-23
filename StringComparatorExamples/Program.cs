using StringComparator;
using System;

namespace StringComparatorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fist = "Programing";
            string second = "program";
            Console.WriteLine(Comparator.Compare(fist, second));
            Console.ReadKey();
        }
    }
}
