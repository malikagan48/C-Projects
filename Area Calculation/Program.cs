using Area_Calculation;

Console.WriteLine("Please select the figure you want to calculate: ");
Console.WriteLine("************************************************");
Console.WriteLine("Circle or Sphere                             (1)");
Console.WriteLine("Triangular or Triangular Prism               (2)");
Console.WriteLine("Square or Cube                               (3)");
Console.WriteLine("Rectangle or Rectangle Prism                 (4)");
int shape = Convert.ToInt32(Console.ReadLine());

switch (shape)
{

    case 1:
        circle.Calculation();
        break;

    case 2:
        Triangle.Calculation();
        break;

    case 3:
        Square.Calculation();
        break;

    case 4:
        rectangle.Calculation();
        break;

    default:
        WarningMessage.Warning();
        break;
}