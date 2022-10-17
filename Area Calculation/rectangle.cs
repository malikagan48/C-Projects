using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculation
{
    public class rectangle
    {
        public static void Calculation()
        {
            Console.WriteLine("Please enter the length of the short side:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the length of the long side:");
            int b = Convert.ToInt32(Console.ReadLine());

            SizeSelection.Selection();
            int dimension = Convert.ToInt32(Console.ReadLine());

            switch (dimension)
            {
                case 1:
                    double perimeter = 2 * (a + b);
                    Console.WriteLine("perimeter: " + perimeter);
                    break;

                case 2:
                    double area = a * b;
                    Console.WriteLine("area: " + area);
                    break;

                case 3:
                    Console.WriteLine("Enter height:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    double gauge = a * b * c;
                    Console.WriteLine("gauge: " + gauge);
                    break;

                default:
                    WarningMessage.Warning();
                    break;
            }
        }
    }
}
