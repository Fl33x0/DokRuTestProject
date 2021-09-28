using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4 result:");
            Console.WriteLine(MyFunctions.DigitsSumm(173));

            Console.WriteLine(string.Empty);
            Console.WriteLine("Task 5 result:");
            foreach (var item in MyFunctions.CentsToCoins(1237))
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine("Task 6 result:");
            Console.WriteLine(MyFunctions.GetBiggestNumber(1236368));

            Console.WriteLine(string.Empty);
            Console.WriteLine("Task 7 result:");
            Console.WriteLine(MyFunctions.TriangleStringSumm(10));

            Console.WriteLine(string.Empty);
            Console.WriteLine("Task 8 result:");
            Console.WriteLine(MyFunctions.GetFive());
        }
    }
}
