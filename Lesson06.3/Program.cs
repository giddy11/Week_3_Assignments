// See https://aka.ms/new-console-template for more information

int numbers;
Console.Write("Enter the total number of digits you would want to enter: ");
int numberOfDigitsToenter = int.Parse(Console.ReadLine());

if (numberOfDigitsToenter <= 0)
{
    Console.WriteLine("Number has to be greater than 0");
}
else
{
    Console.WriteLine("Type the numbers here: ");
    for (int i = 1; i <= numberOfDigitsToenter; i++)
    {
        Console.Write($"Counter[{i}] = ");
        numbers = int.Parse(Console.ReadLine());
        if (numbers % (7 * 3) == 0)
        {
            Console.WriteLine("Number entered is divisible by 3 and 7");
            break;
        }
        Console.WriteLine();
    }
}

