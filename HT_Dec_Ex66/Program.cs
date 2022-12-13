// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Pls enter first number M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("Pls enter second number N = ");
int N = int.Parse(Console.ReadLine());
 
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}

Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
Console.ReadLine();