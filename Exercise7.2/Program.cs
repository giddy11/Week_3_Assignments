// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the length of the first array: ");
int lengthOne = int.Parse(Console.ReadLine());
int[] arrayOne = new int[lengthOne];

Console.WriteLine("Enter the length of the second array: ");
int lengthTwo = int.Parse(Console.ReadLine());
int[] arrayTwo = new int[lengthTwo];

Console.WriteLine("Enter elements for the first array:");
for (int i = 0; i < arrayOne.Length; i++)
{
    Console.Write($"Element {i}: ");
    arrayOne[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nEnter elements for the second array:");
for (int i = 0; i < arrayTwo.Length; i++)
{
    Console.Write($"Element {i}: ");
    arrayTwo[i] = int.Parse(Console.ReadLine());
}

if (lengthOne == lengthTwo)
{
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i] != arrayTwo[i])
        {
            Console.WriteLine("THEY ARE NOT EQUAL!!!");
            break;
        }
        else
        {
            Console.WriteLine("THEY ARE EQUAL");
            break;
        }
    }
}
else
{
    Console.WriteLine("THEY ARE NOT EQUAL");
}
