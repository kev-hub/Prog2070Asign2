using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            int radius = 0;
            int menuOption = 0;
            //Gets a radius from a user but dosent set the radius of the circle causing gir
            radius = GetRadiusFromUserInput(radius);

            do
            {
                do
                {

                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();
                    //error message dosent display if negative number  is given
                    try
                    {
                        //parses negative numbers too
                        menuOption = int.Parse(Console.ReadLine());
                    }
                    //exception mot defined
                    catch (Exception ex)
                    {
                        //Please select a number from a number from the menu
                        Console.WriteLine("Wrong option, please select from the menu:");
                        Console.WriteLine();
                    }


                } while (menuOption == 0 || menuOption < 0 || menuOption > 5);

                switch (menuOption)
                {
                    case 1:
                        radius = circle.GetRadius();
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;
                    case 2:

                        radius = GetRadiusFromUserInput(radius);
                        circle.SetRadius(radius);
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + Math.Round(circle.GetCircumference(), 2));
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("The Area of the circle is: " + Math.Round(circle.GetArea(), 2));
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (menuOption > 0 || menuOption < 5);
        }

        private static int GetRadiusFromUserInput(int radius)
        {
            do
            {
                //Extra spacing not required
                Console.WriteLine("Please enter radius value: ");
                Console.WriteLine();
                // I can give the radius a negative number to the radius with no issues
                try
                {
                    //parses negative numbers too
                    radius = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    //comman users dont know what a int is , use number instead
                    Console.WriteLine("Not the correct format, please insert a int greater than zero!");
                    Console.WriteLine();
                }
                //while only checks if it is zero so negative radius are possible
            } while (radius == 0);
            return radius;
        }

    }

}
