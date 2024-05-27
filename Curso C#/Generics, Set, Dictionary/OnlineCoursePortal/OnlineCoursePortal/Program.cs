using System;
using OnlineCoursePortal.Entities;

namespace OnlineCoursePortal
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Registration> set = new HashSet<Registration>();

            Console.Write("How many students for Course A: ");
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                var code = int.Parse(Console.ReadLine());

                set.Add(new Registration { Code = code });
            }

            Console.Write("How many students for Course B: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var code = int.Parse(Console.ReadLine());

                set.Add(new Registration { Code = code });
            }

            Console.Write("How many students for Course C: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var code = int.Parse(Console.ReadLine());

                set.Add(new Registration { Code = code });
            }

            Console.WriteLine("Total Students: " + set.Count);
        }
    }
}