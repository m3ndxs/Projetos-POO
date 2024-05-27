using System.Globalization;
using ServicePayment.Entities;
using ServicePayment.Services;

namespace ServicePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            
            Console.Write("Number: ");
            var contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date(dd/MM/yyyy): ");
            var contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            var contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            var months = int.Parse(Console.ReadLine());

            // Instanciamento do objeto Contract
            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            // Instanciando o objeto ContractService com o objeto PaypalService(contem as taxas etc);
            ContractService contractService = new ContractService(new PaypalService());
            
            // Chamada da função ProcessContract, parâmetros obj myContract e months;
            contractService.ProcessContract(myContract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}