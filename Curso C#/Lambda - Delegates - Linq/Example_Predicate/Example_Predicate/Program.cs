using Example_Predicate.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Example_Predicate {
    class Program 
    {
        static void Main(string[] args) 
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();

            /*list.RemoveAll(ProductTest);*/

            /*Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(act);*/

            foreach (string s in result) 
            {
                Console.WriteLine(s);
            }
        }
        /*public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }*/

    }
}