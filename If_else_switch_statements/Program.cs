// See https://aka.ms/new-console-template for more information

int a = 1;
int b = 6;
int c = 5;
double d = Math.Pow(b,2) - (4 * a * c);

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
