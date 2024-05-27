using System.Globalization;
using Restriction_Generics.Services;
using Restriction_Generics.Entities;

namespace Restriction_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            var n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                
                var name = vect[0];
                var price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Most Expensive:");
            Console.WriteLine(max);
        }
    }
}