using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConversaoDolarReal(cotacaoDolar, quantia);

            Console.WriteLine("Valor a ser pago em reais: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}