// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 300; i++)
{
    if (i % 7 == 0 && i % 35 != 0)
    {
        Console.WriteLine(i);
        continue;
    }
}
