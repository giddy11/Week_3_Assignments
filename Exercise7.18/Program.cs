// See https://aka.ms/new-console-template for more information

var numbers = new[] { 1, 5, 0, 34, 3, 9 };

SortArray(numbers);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

//first method that will be called
void SortArray(int[] numbers)
{
    Quicksort(numbers, 0, numbers.Length - 1);
}


void Quicksort(int[] numbers, int left, int right)
{
    int i = left;
    int j = right;

    var pivot = numbers[(left + right) / 2];//the pivot splits the aarrays into two parts which is left and right(the average)

    while (i <= j)
    {
        while (numbers[i] < pivot)
        {
            i++;
        }
        while (numbers[j] > pivot)
        {
            j--;
        }

        if (i <= j)
        {
            var temp = numbers[i];      //swapping
            numbers[i] = numbers[j];
            numbers[j] = temp;

            i++;
            j--;
        }
    }

    if (j > left)
    {
        Quicksort(numbers, left, j);        //Recurssion
    }
    if (i < right)
    {
        Quicksort(numbers, right, i);
    }
}