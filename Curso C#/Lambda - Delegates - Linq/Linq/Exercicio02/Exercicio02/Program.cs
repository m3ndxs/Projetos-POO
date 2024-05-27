using Exercicio02.Entities;
using System.Globalization;
using System.Linq;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) { 
                    string[] fields = sr.ReadLine().Split(", ");
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            var salaryBase = list.Where(employee => employee.Salary > 2000).OrderBy(employee => employee.Name).Select(employee => employee.Email);
            
            Console.WriteLine("Email of people whose salary is more than 2000.00:");
            
            foreach (string email in salaryBase) {
                Console.WriteLine(email);
            }

            var sumSalary = list.Where(employee => employee.Name[0] == 'M').Sum(employee => employee.Salary);

            Console.WriteLine("Sum of salary of people whose name statrts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}