using System;
namespace Uppgift_3._15
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int Total = timmar * 80;

            if (timmar <= 11)
            {
                Console.WriteLine("Det kommer kosta " + Total + "Kr.");
            }
            else if (timmar >= 11)
            {
                Console.WriteLine("Du får inte hyra bilen unde såhär " + timmar + " många timmar.");
            }
        }
    }
}