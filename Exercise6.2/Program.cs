// See https://aka.ms/new-console-template for more information

Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

for (int num = 1; num <= n; num++)
{
    if (num % (3 * 7) == 0)
    {
        continue;
    }
    Console.Write($" {num}");
}