using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculation
{
    public class Square
    {
        public static void Calculation()
        {
            Console.WriteLine("Please enter the side length:");
            int a = Convert.ToInt32(Console.ReadLine());

            SizeSelection.Selection();
            int size = Convert.ToInt32(Console.ReadLine());

            switch (size)
            {
                case 1:
                    double perimeter = 4 * a;
                    Console.WriteLine("perimeter: " + perimeter);
                    break;

                case 2:
                    double area = Math.Pow(a, 2);
                    Console.WriteLine("area: " + area);
                    break;

                case 3:
                    double gauge = Math.Pow(a, 3);
                    Console.WriteLine("gauge: " + gauge);
                    break;

                default:
                    WarningMessage.Warning();
                    break;

            }
        }
    }
}
