// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = ReadInt("Pls enter qty of rows: ");
int columns = ReadInt("Ps enter qty of columns: ");
int elementrows = ReadInt("Pls enter element's row: ") - 1;
int elementcolumns = ReadInt("Ps enter elemetn's column: ") - 1;

int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }

Console.WriteLine();

    for (int i = 0; i < numbers.GetLength(0); i++)
     {
        for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (elementrows < 0 | elementrows > array.GetLength(0) - 1 | elementcolumns < 0 | elementcolumns > array.GetLength(1) - 1)
        {
          Console.WriteLine("There is no element with entered positions"); 
        }
        else
        {
           Console.WriteLine("Requested number = {0}", numbers[elementrows,elementcolumns]);
        }
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

