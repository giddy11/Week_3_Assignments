// See https://aka.ms/new-console-template for more information

double[,] matrixA = new double[3, 3];
double[,] matrixB = new double[3, 3];
double[,] sumOfAB = new double[3, 3];//Addition of matrixA and matrixB
double[,] subtractionOfAB = new double[3, 3];   //Subtraction of matrixA and matrixB
double[,] multiplicationOfAB = new double[3, 3];//Multiplication of matrixA and matrixB 
double detA = 0;//Determinant of matrixA
double detB = 0;//Determinant of matrixB

// MATRIX-A DETAILS
Console.WriteLine("Enter all the element for matrixA: ");
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int col = 0; col < matrixA.GetLength(1); col++)
    {
        Console.Write($"matrixA[{row},{col}] = ");
        matrixA[row, col] = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Here are your matrixA formatted inputs:");
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int col = 0; col < matrixA.GetLength(1); col++)
    {
        Console.Write($"  {matrixA[row, col]} ");
    }
    Console.WriteLine();
}
//MATRIX - B DETAILS
Console.WriteLine("Enter all the element for matrixB: ");
for (int row = 0; row < matrixB.GetLength(0); row++)
{
    for (int col = 0; col < matrixB.GetLength(1); col++)
    {
        Console.Write($"matrixB[{row},{col}] = ");
        matrixB[row, col] = double.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Here are your matrixB formatted inputs:");
for (int row = 0; row < matrixB.GetLength(0); row++)
{
    for (int col = 0; col < matrixB.GetLength(1); col++)
    {
        Console.Write($" {matrixB[row, col]} ");
    }
    Console.WriteLine();
}
//CALCULATIONS FOR ADDITION,SUBTRACTION AND MULTIPLICATION OF THE 2 MATRIXES
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int col = 0; col < matrixA.GetLength(1); col++)
    {
        sumOfAB[row, col] = matrixA[row, col] + matrixB[row, col];
        subtractionOfAB[row, col] = matrixA[row, col] - matrixB[row, col];
        multiplicationOfAB[row, col] = matrixA[row, col] * matrixB[row, col];
    }
    Console.WriteLine();
}
//DISPLAY ADDITION
Console.WriteLine("The Addition of MatrixA and MatrixB is: ");
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int col = 0; col < matrixA.GetLength(0); col++)
    {
        Console.Write($" {sumOfAB[row, col]} ");
    }
    Console.WriteLine();
}
//DISPLAY SUBTRACTION
Console.WriteLine("The Subtraction of MatrixA and MatrixB is: ");
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int col = 0; col < matrixA.GetLength(0); col++)
    {
        Console.Write($" {subtractionOfAB[row, col]} ");
    }
    Console.WriteLine();
}
//DISPLAY MULTIPLICATION
Console.WriteLine("The Multiplication of MatrixA and MatrixB is: ");
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int col = 0; col < matrixA.GetLength(0); col++)
    {
        Console.Write($" {multiplicationOfAB[row, col]} ");
    }
    Console.WriteLine();
}
//DETERMINANT CALCULATIONS FOR BOTH MATRIX-A AND MATRIX-B
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    detA += matrixA[0, row] * (matrixA[1, (row + 1) % 3] * matrixA[2, (row + 2) % 3]
            - matrixA[1, (row + 2) % 3] * matrixA[2, (row + 1) % 3]);

    detB += matrixB[0, row] * (matrixB[1, (row + 1) % 3] * matrixB[2, (row + 2) % 3]
            - matrixB[1, (row + 2) % 3] * matrixB[2, (row + 1) % 3]);
}
//DISPLAY DETERMINANTS FOR MATRIX-A AND MATRIX-B
Console.Write($"The Determinant of matrixA is: {detA} \n\n");
Console.Write($"The Determinant of matrixB is: {detB} \n\n");

if (detA > detB)
{
    Console.WriteLine("The determinant of matrixA is greater than matrixB");
}
else if (detA < detB)
{
    Console.WriteLine("The determinant of matrixB is greater than matrixA");
}
else
{
    Console.WriteLine("The both matrixes (that is matrixA and matrixB) are equal");
}
