// See https://aka.ms/new-console-template for more information

int sum = 0;
int row = 0;
int col = 0;

Console.Write("Enter the number of the rows: ");
int numberOfRows = int.Parse(Console.ReadLine());           //for n

Console.Write("Enter the number of the columns: ");
int numberOfCols = int.Parse(Console.ReadLine());           //for m

int[,] matrix = new int[numberOfRows, numberOfCols];
Console.WriteLine("Enter the cells of the matrix:\n");

for (int i = 0; i < numberOfRows; i++)
{

    for (int j = 0; j < numberOfCols; j++)
    {
        Console.Write($"matrix[{i},{j}] = ");
        matrix[i, j] = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
}

//Display the inputted Matrix
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();
}

//Finding the maxima 3*3
for (int tempRow = 0; tempRow < matrix.GetLength(0); tempRow++)
{
    for (int tempCol = 0; tempCol < matrix.GetLength(1); tempCol++)
    {
        int tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        if (tempSum > sum)
        {
            row = tempRow;
            col = tempCol;
            sum = tempSum;
        }
    }
}
Console.WriteLine("The best platform is:");
Console.WriteLine($" {matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}");
Console.WriteLine($" {matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}");
Console.WriteLine($" {matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
Console.WriteLine($"The maximal sum is: {sum}");
