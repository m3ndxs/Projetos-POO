using System;

namespace Generics_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            var n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());

                printService.AddValue(x);
            }  

            var a = printService.First();
            var b = a + 2;

            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}