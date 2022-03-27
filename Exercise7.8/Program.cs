// See https://aka.ms/new-console-template for more information

int[] arr = { 5, 9, 7, 6, 4, 0, 2, 3, 8, 1 };

for (int i = 0; i < arr.Length - 1; i++)
{
    int minimumPos = i;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] < arr[minimumPos])
        {
            minimumPos = arr[j];
        }

        if (minimumPos != i)                 //We now have a number less than minimum value
        {
            int temp = arr[j];              //Temporary variable
            arr[j] = arr[minimumPos];
            arr[minimumPos] = temp;
        }
    }
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"{arr[i]}");
}
