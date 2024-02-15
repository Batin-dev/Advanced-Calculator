using System;

namespace Plus_Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            double calsayi1;  
            double calsayi2;
            int secim571;
            double plussonuc;
            double subsonuc;
            double multi;
            double dividesonuc;  

            Console.WriteLine("Select your work");
            Console.WriteLine("1- Plus  2-Subtraction  3-Multiplication  4-Divide");
            secim571 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wait...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Type first Number");
            calsayi1 = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Type second Number");
            calsayi2 = Convert.ToDouble(Console.ReadLine());  

            switch (secim571)
            {
                case 1:
                    plussonuc = calsayi1 + calsayi2;
                    Console.WriteLine(plussonuc);
                    break;
                case 2:
                    subsonuc = calsayi1 - calsayi2;
                    Console.WriteLine(subsonuc);
                    break;
                case 3:
                    multi = calsayi1 * calsayi2;
                    Console.WriteLine(multi);
                    break;
                case 4:
                    dividesonuc = calsayi1 / calsayi2;
                    Console.WriteLine(dividesonuc);  
                    break;
            }

            Console.ReadLine();
        }
    }
}
