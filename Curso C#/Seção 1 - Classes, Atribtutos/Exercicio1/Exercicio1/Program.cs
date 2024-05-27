using System;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            Dados person1, person2;
            
            person1 = new Dados();
            person2 = new Dados();

            Console.WriteLine("Informe os dados da primeira pessoa:");
            Console.Write("Nome: ");
            person1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            person1.Age = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Informe os dados da segunda pessoa:");
            Console.Write("Nome: ");
            person2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            person2.Age = int.Parse(Console.ReadLine());

            if (person1.Age > person2.Age) {
                Console.WriteLine("Pessoa mais velha: " + person1.Name);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + person2.Name);
            }
        }
    }
}