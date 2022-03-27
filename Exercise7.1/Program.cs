// See https://aka.ms/new-console-template for more information

int[] arrayOfIntegers = new int[20];
for (int i = 0; i < arrayOfIntegers.Length; i++)
{
    arrayOfIntegers[i] = i * 5;
    Console.WriteLine($"{i}. {arrayOfIntegers[i]}");
}
