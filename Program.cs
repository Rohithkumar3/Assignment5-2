using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmenr_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using a for loop to display the first 10 natural numbers
            Console.WriteLine("First 10 natural numbers: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Using a while loop to print the first 10 even natural numbers
            Console.WriteLine("\nFirst 10 even natural numbers: ");
            int evenNumber = 2;
            int evenCount = 0;
            while (evenCount < 10)
            {
                Console.WriteLine(evenNumber);
                evenNumber += 2;
                evenCount++;
            }

            // Using a do-while loop to print the first 10 odd natural numbers
            Console.WriteLine("\nFirst 10 odd natural numbers : ");
            int oddNumber = 1;
            int oddCount = 0;
            do
            {
                Console.WriteLine(oddNumber);
                oddNumber += 2;
                oddCount++;
            } while (oddCount < 10);
            Console.ReadKey();
    
}
    }
}
