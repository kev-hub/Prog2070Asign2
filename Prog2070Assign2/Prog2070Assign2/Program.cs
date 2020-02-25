using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2070Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSideOne =  0;
            int userSideTwo = 0;
            int userSideThree = 0;
            Menu();
            ///creates menu 
            void Menu()
            {
                Console.WriteLine("Welcome to my Triangle application please select a number.");
                Console.WriteLine("1. Make a Triangle");
                Console.WriteLine("2. Exit");
                ///calls methods
                switch (Console.ReadLine())
                {
                    case "1":
                        GetTriangle();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invaild Number: please enter a number");
                        break;
                }
                Menu();
            }



            void GetTriangle()
            {
                Console.WriteLine("Enter a new All three sides ");
                Console.WriteLine("Side 1 :");

                if (int.TryParse(Console.ReadLine(), out userSideOne))
                {

                    Console.WriteLine("Side 2 :");

                    if (int.TryParse(Console.ReadLine(), out userSideTwo))
                    {
                        Console.WriteLine("Side 3 :");

                        if (int.TryParse(Console.ReadLine(), out userSideThree))
                        {
                         string message =  TriangleSolver.Analyse(userSideOne,userSideTwo,userSideThree);
                            Console.WriteLine(message);

                        }
                        else
                        {
                            Console.WriteLine("Invalid Number :Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number :Please enter a number");

                    }


                    
                }
                else
                {
                    Console.WriteLine("Invalid Number :Please enter a number");
              
                }

         
                Menu();

            }








        }
    }
}
