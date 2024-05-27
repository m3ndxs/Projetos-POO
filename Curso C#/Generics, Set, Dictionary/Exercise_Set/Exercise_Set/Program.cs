using System;
using System.IO;
using Exercise_Set.Entities;

namespace Exercise_Set
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            // Logica para ler um arquivo e imprimir linha por linha
            Console.Write("Enter file full path: ");
            var path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');

                        var name = line[0];
                        var instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant });

                    }

                    Console.WriteLine("Total Users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}