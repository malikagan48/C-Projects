
Console.WriteLine("Enter the number of pieces");
int z =int.Parse(Console.ReadLine());
Methods m= new Methods();
m.calculate(z);
Console.ReadKey();


public class Methods
{
    int a = 1;
    int b = 1;
    int c;
    int total = 0;
    public void calculate(int z)
    {
        for (int i = 1; i<=z; i++)
        {
            c = a + b;
            a = b;
            b = c;
            total+=c;
        }
        Console.WriteLine("Average of the series:" + total/z);
    }

}
