// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rowsFirstMatrix = ReadInt("Pls enter qty of rows for MatrixA: ");
int columnsFirstMatrix = ReadInt("Pls enter qty of columns for MatrixA: ");
int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];

int rowsSecondMatrix = ReadInt("Pls enter qty of rows for MatrixB: ");
int columnsSecondMatrix = ReadInt("Pls enter qty of columns for MatrixB: ");
int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];

if (columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Multiplicaction is not possible."
+ " Qty of MatrixA columns must be the same as qty of MatrixB rows");
    return;
}

FillMatrixRandomNumbers(firstMatrix);
WriteMatrix(firstMatrix);
FillMatrixRandomNumbers(secondMatrix);
WriteMatrix(secondMatrix);
int[,] numbersResult = new int[rowsFirstMatrix, columnsSecondMatrix];

for (int j = 0; j < numbersResult.GetLength(1); j++)
{
    int sum = 0;
    int multipl = 1;
    for (int i = 0; i < numbersResult.GetLength(0); i++)
    {
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            multipl = 1;
            multipl = firstMatrix[i, k] * secondMatrix[k, j];
            sum += multipl;
        }
        numbersResult[i, j] = sum;
        sum = 0;
    }
}
WriteMatrix(numbersResult);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
