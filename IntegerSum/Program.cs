start:
Console.WriteLine("Enter the number ");
int n = Convert.ToInt32(Console.ReadLine());
if (n%2==1 || n<=0)
{
    Console.WriteLine("The entered value cannot be odd, 0 or negative.");
    goto start;
}
int[] value = new int[n];
double[] total = new double[(n / 2)];
int j = 0;
int k = 0;
for (int i = 0; i < n; i++)
{
    Console.Write((i + 1) + ". enter the value: ");
    value[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= n; i += 2)
{
    if (value[i] == value[j])
    {
        total[k] = Math.Pow((value[i] + value[j]), 2);
    }
    else
        total[k] = value[i] + value[j];
    k++;
    j += 2;
}
Console.Write("Result ==> ");
foreach (var item in total)
{
    Console.Write(item + " ");
}
Console.ReadKey();