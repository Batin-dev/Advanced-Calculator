using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeicalSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqtnum;

            Console.WriteLine("Write your number");
            sqtnum = double.Parse(Console.ReadLine());

            double mathsqtnum = Math.Sqrt(sqtnum);
            Console.WriteLine(mathsqtnum);

            Console.WriteLine("Press enter to exit...");

            Console.ReadLine();

            Environment.Exit(0);

            

        }
    }
}
