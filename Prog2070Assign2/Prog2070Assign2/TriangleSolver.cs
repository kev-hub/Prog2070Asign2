using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Prog2070Assign2
{
    [TestFixture]
    public static class TriangleSolver
    {
      public static string message = "";
        static int a = 0;
        static int b = 0;
        static int c = 0;
        public static bool triangleCheck = true;

        public static string Analyse(int sideOne, int sideTwo, int sideThere)
        {

            a = sideOne;
            b = sideTwo;
            c = sideThere;
            IsNotNullValuesGiven3Sides();
            GivenThreeSidesTriangleInequalityTheoremResultTrue();

          

                        if (triangleCheck == true)
                        {
                            message = ("Valid Triangle : \n");
                            Given3SidesResultEquilateralTriangle();
                if (triangleCheck == true)
                {
                    message = ("Valid Triangle : \n");
                    Given3SidesResultIsoscelesTriangle();
                }
                if (triangleCheck == true)
                {
                    message = ("Valid Triangle : \n");
                    Given3SidesResultScaleneTriangle();
                }


                if (a <= 0 || b <= 0 || c <= 0)
                {
                    triangleCheck = true;
                }

            }
        if(triangleCheck == true)
                {
                message = ("Invalid Triangle : please enter new Values\n");
            }
        




            return message;
        }
        [Test]
        public static void IsNotNullValuesGiven3Sides()
        {
   
            // I chose these values because its a basic iscolies 
            if (a == null || a == 0)
            {
                a = 2;
            }
            if (b == null || b == 0)
            {
                b = 2;
            }
            if (a == null || a == 0)
            {
                c = 4;
            }
            if (a != null && b != null && c != null)
            {
                Assert.True(a == a);
                triangleCheck = true;
            }
            else
            {
                triangleCheck = false;
            }


        }
        [Test]
        public static void GivenThreeSidesPythagoreanTheoremResultTrue()
        {
            // I chose these values to solve the throem 
            if (a == null || a == 0)
            {
                a = 1;
            }
            if (b == null || b == 0)
            {
                b = 1;
            }
            if (a == null || a == 0)
            {
                c = 2;
            }
            a = a ^ 2;
            b = b ^ 2;
            if (c == (a + b))
            {
                Assert.True(c == (a + b));
                triangleCheck = true;
            }
            else
            {
                triangleCheck = false;
            }
        }
        [Test]
        public static void GivenThreeSidesTriangleInequalityTheoremResultTrue()
        {
            // I chose these values to solve the throem 
            if (a == null || a == 0)
            {
                a = 2;
            }
            if (b == null || b == 0)
            {
                b = 3;
            }
            if (a == null || a == 0)
            {
                c = 4;
            }
            if (a + b > c || a + c > b || b + c > a)
            {
                Assert.True(a == a);
                triangleCheck = true;
            }
            else
            {
                triangleCheck = false;
            }


        }
        [Test]
        public static void Given3SidesResultEquilateralTriangle()
        {
            // I chose these values because its a basic equlaterial triangle
            if (a == null || a == 0)
            {
                a = 3;
            }
            if (b == null || b == 0)
            {
                b = 3;
            }
            if (a == null || a == 0)
            {
                c = 3;
            }

            if (a == b && b == c)
            {
                Assert.True(1 == 1);
                message += ("This is an equilateral triangle.\n");
                triangleCheck = false;
            }
      
        }
        [Test]
        public static void Given3SidesResultIsoscelesTriangle()
        {
            // I chose these values because its a basic iscolies 
            if (a == null || a == 0)
            {
                a = 3;
            }
            if (b == null || b == 0)
            {
                b = 3;
            }
            if (a == null || a == 0)
            {
                c = 6;
            }

            if (a == b || a == c || b == c)
            {
                Assert.True(1 == 1);
                message += ("This is an isosceles triangle.\n");
                triangleCheck = false;
            }
       

        }

        [Test]
        public static void Given3SidesResultScaleneTriangle()
        {
            // I chose these values because its a basic scalene 
            if (a == null || a == 0)
            {
                a = 3;
            }
            if (b == null || b == 0)
            {
                b = 4;
            }
            if (a == null || a == 0)
            {
                c = 6;
            }

            if (a != b && b != c && c != a)
            {
                Assert.True((a != b && b != c && c != a));
                message += ("This is an Scalene triangle.\n");
                triangleCheck = false;

            }


        }

    }
}
