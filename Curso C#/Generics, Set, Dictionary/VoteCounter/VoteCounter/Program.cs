using System;
using System.IO;

namespace VoteCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            var path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>(); 

                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        var candidate = votingRecord[0];
                        var votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;  
                        }
                    }

                    foreach(var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}