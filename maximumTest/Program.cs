using System;

namespace maximumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the maximum test problem using generics!!!");
            int[] intArray = { 112, 344, 432, 555, 678, 888, 911, 999 };
            FindMaximum.GenericMaximum<int> generic = new FindMaximum.GenericMaximum<int>(intArray);
            generic.PrintMaximumValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78, 4.10, 3.29, 5.87, 6.21 };
            FindMaximum.GenericMaximum<double> genericDouble = new FindMaximum.GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaximumValue();
            string[] stringArray = { "Anna", "Xavier", "Zee", "Luhan", "Yohan", "Liam" };
            FindMaximum.GenericMaximum<string> genericString = new FindMaximum.GenericMaximum<string>(stringArray);
            genericString.PrintMaximumValue();
        }
    }
}
