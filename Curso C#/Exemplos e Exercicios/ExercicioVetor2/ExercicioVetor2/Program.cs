using System;
using System.Globalization;

namespace ExercicioVetor2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for (int i = 0; i < n; i++) { 
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product { Nome = nome, Preco = preco };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) { 
                sum += products[i].Preco;
            }

            double avg = sum/ n;
            Console.WriteLine("Preco Medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}