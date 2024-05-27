using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise_example.Entities;

namespace Exercise_example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data:");
                
                Console.Write("Outsourced (y/n): ");
                var ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Hours: ");
                var hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    var additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}