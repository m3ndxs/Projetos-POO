using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n1 = int.Parse(Console.ReadLine());
                var n2 = int.Parse(Console.ReadLine());

                var result = n1 / n2;

                Console.WriteLine(result);
            } 
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! ");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error!" + e.Message);
            }
            finally
            {
                Console.WriteLine("Final");
            }
        }
    }
}