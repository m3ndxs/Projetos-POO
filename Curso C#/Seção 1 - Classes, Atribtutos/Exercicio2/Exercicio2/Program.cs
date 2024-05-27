using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            Dados func1, func2;
            func1 = new Dados();
            func2 = new Dados();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avg = (func1.Salario + func2.Salario) / 2.0;

            Console.WriteLine("Salário médio: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}