using System;

namespace Mainofcalculator
{
    class Program
    {


        static void Main(string[] args)
        {

            int perfectchoice;

            Console.WriteLine("Select your work?");

            Console.WriteLine("1- +,*,-,/");
            Console.WriteLine("2- Square , Cube , speical");
            Console.WriteLine("3- Taking root of number");

            perfectchoice = int.Parse(Console.ReadLine());

            switch (perfectchoice)
            {

                case 1:
                    PlusSubSYS();
                    break;

                case 2:
                    SquareAndOtherEvents();
                    break;
                case 3:
                    Speicalsqt();
                    break;

            }


            



        }
        static void PlusSubSYS()
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
            Console.WriteLine("---------------------------");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
            Environment.Exit(0);



        }
        static void SquareAndOtherEvents()
        {
            int num1;

            int baseofnum;

            int choice;

            int lostnum = 1;

            Console.WriteLine("Type your number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1- Get Square 2- Get Cube 3- Get Speical");
            choice = Convert.ToInt32(Console.ReadLine());

            #region
            switch (choice)
            {
                case 1:
                    Console.WriteLine(num1 * num1);
                    break;
                case 2:
                    Console.WriteLine(num1 * num1 * num1);
                    break;
                case 3:


                    Console.WriteLine("Type your base");
                    baseofnum = Convert.ToInt32(Console.ReadLine());
                    if (baseofnum == 1)
                    {
                        Console.WriteLine(num1);
                    }
                    else if (baseofnum == 2)
                    {
                        Console.WriteLine(num1 * num1);

                    }
                    else if (baseofnum == 3)
                    {
                        Console.WriteLine(num1 * num1 * num1);
                    }
                    else if (baseofnum > 3)
                    {
                        lostnum = num1 * num1 * num1 * num1;
                        baseofnum = baseofnum - 4;
                        if (baseofnum != 0)
                        {
                            while (baseofnum >= 1)
                            {
                                lostnum = lostnum * num1;
                                --baseofnum;


                            }
                        }


                    }
                    Console.WriteLine(lostnum);
                    break;

                    //min 4

            }
            #endregion
            Console.WriteLine("Press enter for exit");

            Console.ReadLine();
            Console.Clear();

            Environment.Exit(0);
        }
        static void Speicalsqt()
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
