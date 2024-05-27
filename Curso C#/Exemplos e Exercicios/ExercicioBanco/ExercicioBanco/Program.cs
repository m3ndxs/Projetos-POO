using System;
using System.Globalization;

namespace ExercicioBanco {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depóstio inicial (s/n)? ");
            char opcaoDeposito = char.Parse(Console.ReadLine());

            if(opcaoDeposito == 's' || opcaoDeposito == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta = new ContaBancaria(numero, nome, saldo);
            }
            else {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(conta.Saldo >= saque) {
                conta.Saque(saque);
            }
            else {
                Console.WriteLine("Saldo insuficiente para saque");
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}