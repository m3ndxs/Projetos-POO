using System;
using Excecao_Personalizada.Entities;
using Excecao_Personalizada.Entities.Exceptions;

namespace Excecao_Personalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                var roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                var checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                var checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine("RESERVATION: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine();
                Console.WriteLine("UPDATE RESERVATION: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            
        }
    }
}
