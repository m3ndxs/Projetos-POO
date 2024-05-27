using System;
using System.Globalization;

namespace Exercicio2._3 {
    class Program {
        static void Main(string[] args) { 
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if(aluno.NotaFinal() >= 60.0) {
                Console.WriteLine("Aprovado!!!");
            }
            else {
                Console.WriteLine("Reprovado!!!");
                
                double notaFaltante = 60.0 - aluno.NotaFinal();
                Console.WriteLine("Faltaram " + notaFaltante.ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}