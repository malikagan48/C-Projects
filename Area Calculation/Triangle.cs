using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculation
{
    public class Triangle
    {
        public static void Calculation()
        {
            Console.WriteLine("Please enter the first side length:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second side length:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third  side length:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of the third edge:");
            int h = Convert.ToInt32(Console.ReadLine());

            SizeSelection.Selection();
            int size = Convert.ToInt32(Console.ReadLine());

            switch (size)
            {
                case 1:
                    double perimeter = a + b + c;
                    Console.WriteLine("perimeter: " + perimeter);
                    break;

                case 2:
                    double area = (c * h) / 2;
                    Console.WriteLine("area: " + area);
                    break;

                case 3:
                    Console.WriteLine("Enter height:");
                    int h1 = Convert.ToInt32(Console.ReadLine());
                    double gauge = (c * h * h1) / 2;
                    Console.WriteLine("gauge: " + gauge);
                    break;

                default:
                    WarningMessage.Warning();
                    break;

            }
        }
        }
}
