using System;

namespace LabTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear Friend. Welcome to my World \n");
            Console.WriteLine("I have m416 gun \n");
            Console.WriteLine("Do you want to my gun?");
            Console.WriteLine("Okey let's go \n");
            Console.WriteLine("********");


            Gun gun = new Gun();

            Console.WriteLine("1-Reload");
            Console.WriteLine("2-Shoot");
            Console.WriteLine("3-Full shoot");
            Console.WriteLine("4-Gun Information");
            Console.WriteLine();

            

            bool control = true;

            while (control)
            {
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {


                    case 1:                        
                        Console.WriteLine("1-Reload \n");
                        break;

                    case 2:
                        Console.WriteLine("2-Shoot \n");

                        break;

                    case 3:

                        Console.WriteLine("3-Full shoot \n");

                        break;

                    case 4:

                        Console.WriteLine("4-Gun Information \n");

                        control = false;
                        break;

                }

                static void GetInfo()
                {
                    Console.WriteLine("1-Circle");
                    Console.WriteLine("2-Triangle");
                    Console.WriteLine("3-Rectangle");
                    Console.WriteLine("4-Exit");
                    Console.WriteLine();

                }

            }
        }

    }
}
