// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = ReadInt("Pls enter qty of rows: ");
int columns = ReadInt("Pla enter qty of columns: ");

int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

for (int j = 0; j < numbers.GetLength(0); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
              sum += numbers[i,j];
    }
    Console.Write($"{ sum / numbers.GetLength(0)}; ");
    //Console.WriteLine(sum);
}

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteMatrix(int[,] array)
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

