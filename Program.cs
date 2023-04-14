using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number ");
            int.TryParse(Console.ReadLine(), out int numberOne);
            Console.WriteLine("Enter Second Number ");
            int.TryParse(Console.ReadLine(), out int numberTwo);
            Console.WriteLine("Enter Third Number ");
            int.TryParse(Console.ReadLine(), out int numberThree);
            var byTwo = 0;
            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine($"The biggest number is: {numberOne}");
                    byTwo = numberOne % 2;
                    Console.WriteLine(numberOne < 100 ? "Under 100" : "Equals or bigger than 100");
                }
                else
                {
                    Console.WriteLine($"The biggest number is: {numberThree}");
                    byTwo = numberThree % 2;
                    Console.WriteLine(numberThree < 100 ? "Under 100" : "Equals or bigger than 100");
                }  
            }
            else
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine($"The biggest number is: {numberTwo}");
                    byTwo = numberTwo % 2;
                    Console.WriteLine(numberTwo < 100 ? "Under 100" : "Equals or bigger than 100");
                }
                else
                {
                    Console.WriteLine($"The biggest number is: {numberThree}");
                    byTwo = numberThree % 2;
                    Console.WriteLine(numberThree < 100 ? "Under 100" : "Equals or bigger than 100");
                }
            }
            switch (byTwo)
            {
                case 0:
                    Console.WriteLine("Its an odd number");
                    break;
                default:
                    Console.WriteLine("Its an even number");
                    break;

            }

            Console.ReadLine();
        }
    }
}
