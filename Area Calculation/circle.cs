using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculation
{
    public class circle
    {
        public static void Calculation()
        {
            Console.WriteLine("Please enter radius length: ");
            int r = Convert.ToInt32(Console.ReadLine());

            SizeSelection.Selection();
            int size = Convert.ToInt32(Console.ReadLine());

            switch (size)
            {
                case 1:
                    double perimeter = 2 * Math.PI * r;
                    Console.WriteLine("perimeter: " + perimeter);
                    break;

                case 2:
                    double area = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("area: " + area);
                    break;

                case 3:
                    double gauge = (4 * Math.PI * Math.Pow(r, 3)) / 3;
                    Console.WriteLine("gauge: " + gauge);
                    break;

                default:
                    WarningMessage.Warning();
                    break;
            }
        }
    }
}
