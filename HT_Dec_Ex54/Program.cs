// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = ReadInt("Pls enter qty of rows: ");
int columns = ReadInt("Pls enter qty of columns: ");
int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

for(int k = 0; k < numbers.GetLength(0); k++)
{
    for(int i = 0; i < numbers.GetLength(1); i++)
    {
        for(int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            if(numbers[i, j] < numbers[i, j + 1])
            {
                int temp = numbers[i, j];
                numbers[i, j] = numbers[i, j + 1];
                numbers[i, j + 1] = temp;
            }
        }
    }
}
WriteMatrix(numbers);

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}