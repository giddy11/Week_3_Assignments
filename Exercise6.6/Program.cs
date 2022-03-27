// See https://aka.ms/new-console-template for more information 

Console.Write("Give a value for N: ");
double n = double.Parse(Console.ReadLine()); //double is prefered in case user inputs a decimal

Console.Write("Give a value for K: ");
double k = double.Parse(Console.ReadLine());

for (double i = n - 1; i > 0; i--)
{
    n *= i;
}

for (double i = k - 1; i > 0; i--)
{
    k *= i;
}
Console.WriteLine($"Result is : {n / k}");
