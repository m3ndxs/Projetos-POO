using System.Linq;

namespace Example_Linq {
    class Program 
    {
        static void Main(string[] args) 
        {
            // Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            // Define the query expression
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Exceute the query
            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}