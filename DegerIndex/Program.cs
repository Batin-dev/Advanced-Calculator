using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write("type your number , index =");
                numbers[i] = int.Parse(Console.ReadLine());

                if(numbers[i] %2 == 0)
                {
                    Console.WriteLine(i+" number is couple");
                }
                else
                {
                    Console.WriteLine(i+" number is odd");
                }
            }
            Console.ReadLine();

        }
    }
}
