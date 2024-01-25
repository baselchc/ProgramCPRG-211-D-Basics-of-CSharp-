using System;
using System.IO;
using System.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowNumber;
            do
            {
                Console.WriteLine("Please enter a positive number:");
                lowNumber = int.Parse(Console.ReadLine());
            } while (lowNumber <= 0);

            int highNumber;
            do
            {
                Console.WriteLine("Please enter a number greater than " + lowNumber + ":");
                highNumber = int.Parse(Console.ReadLine());
            } while (highNumber <= lowNumber);
            
            int difference = highNumber - lowNumber;
            Console.WriteLine("The difference between " + highNumber + " and " + lowNumber + " is: " + difference);

            int [] numbers = Enumerable.Range(lowNumber, highNumber - lowNumber + 1).Reverse().ToArray();

            File.WriteAllLines("numbers.txt", numbers.Select(a => a.ToString()));
        }
    }
}

//Basel Chono Campos, CPRG211-D