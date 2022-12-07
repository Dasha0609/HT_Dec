// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = ReadInt("Pls enter qty of rows: ");
int columns = ReadInt("Ps enter qty of columns: ");

double[,] numbers = new double[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

void FillMatrixRandomNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            array[i, j] = Convert.ToDouble(array[i, j])/10;
        }
    }
}

void WriteMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}