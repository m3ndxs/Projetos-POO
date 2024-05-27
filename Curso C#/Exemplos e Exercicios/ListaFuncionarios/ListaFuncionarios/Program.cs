using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaFuncionarios {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            var emp = employees.FirstOrDefault(x  => x.Id == idSearch);

            if(emp == null) {
                Console.WriteLine("This id does not exist!");
            }
            else {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.IncrementSalary(percentage);
            }

            foreach (Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}