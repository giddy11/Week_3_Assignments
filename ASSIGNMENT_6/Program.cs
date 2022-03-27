// See https://aka.ms/new-console-template for more information
//Gideon

Console.Write("Input value for a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value for b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value for c: ");
double c = Convert.ToDouble(Console.ReadLine());

double d = Math.Pow(b, 2) - (4 * a * c);

switch (d)
{
    case > 0:
        Console.WriteLine("Real roots");
        break;
    case < 0:
        Console.WriteLine("Complex roots");
        break;
    default:
        Console.WriteLine("Equal roots");
        break;
}
