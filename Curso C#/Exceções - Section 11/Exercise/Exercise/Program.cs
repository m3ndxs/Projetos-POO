using System;
using System.Globalization;
using Exercise.Entities;
using Exercise.Entities.Exception;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            try
            {
                Console.WriteLine("Enter account data");
                
                Console.Write("Number: ");
                var number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                var holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                var initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                var withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Want to make a deposit(y/n)? ");
                var ch = char.Parse(Console.ReadLine());

                if (ch == 's' || ch == 'S')
                {
                    Console.Write("Enter amount for deposit: ");
                    var amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    account.Deposit(amount);

                    Console.Write("Enter amount for withdraw: ");
                    amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    account.Withdraw(amount);
                }
                else
                {
                    Console.Write("Enter amount for withdraw: ");
                    var amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    account.Withdraw(amount);
                }
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpexted error: " + e.Message);
            }

            
        }
    }
}