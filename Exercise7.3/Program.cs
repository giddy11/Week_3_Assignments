// See https://aka.ms/new-console-template for more information

char[] array1 = new char[5] { 'f', 'c', 'f', 'e', 'z' };
char[] array2 = new char[5] { 'a', 'e', 'c', 'e', 'e' };

for (int i = 0; i < array2.Length; i++)
{
    if (array1[i] < array2[i])
    {
        Console.WriteLine("First array is  lexicographically first.");
        break;
    }
    else if (array1[i] > array2[i])
    {
        Console.WriteLine("Second array is lexicographically first.");
        break;
    }
    else if (array1.Length < array2.Length)
    {
        Console.WriteLine("First array is lexicographically first");
        break;
    }
    else if (array1.Length > array2.Length)
    {
        Console.WriteLine("Second array is lexicographically first");
        break;
    }
    else
    {
        Console.WriteLine("Equal");
        break;
    }
}
