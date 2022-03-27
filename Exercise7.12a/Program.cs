// See https://aka.ms/new-console-template for more information

Console.Write("Enter height of square matrix: ");
int yAxis = int.Parse(Console.ReadLine());

Console.Write("Enter width of square matrix: ");
int xAxis = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= yAxis; i++)
{
    Console.Write($"{i} ");
    sum += i;

    for (int j = 1; j < sum; j++)
    {
        sum += yAxis;
        Console.Write($"{sum} ");
    }
    sum = 0;
    Console.WriteLine();
}



