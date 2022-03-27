// See https://aka.ms/new-console-template for more information

Console.Write("Give a number between 1 - 20: ");
int nSize = int.Parse(Console.ReadLine());

if (nSize > 0 && nSize <= 20)
{
    for (int i = 1; i <= nSize; i++)
    {
        Console.WriteLine();
        for (int j = i; j <= i + (nSize - 1); j++)
        {
            Console.Write($" {j}");
        }
    }
}
else
{
    Console.WriteLine("This Number isnt in the range!!");
}

Console.WriteLine();
