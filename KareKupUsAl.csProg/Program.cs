using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareKupUsAl.csProg
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Return for enter");
            Console.ReadLine();
            Console.Clear();
            



        }
    }
}
