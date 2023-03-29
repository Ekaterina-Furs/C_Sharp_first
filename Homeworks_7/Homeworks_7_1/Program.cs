//Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

Console.Write("Enter the number of rows: ");
double row = double.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
double column = double.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers WITH -> ");
double start = double.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers UP TO -> ");
double stop = double.Parse(Console.ReadLine()!);

double[,] matrix = new double[row, column];


void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(double[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to + 1);
        }
    }
}

FillMatrix(matrix, start, stop);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();