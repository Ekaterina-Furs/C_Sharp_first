//Задача 3: Напишите программу, которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования.

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers WITH -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers UP TO -> ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[row, column];


void PrintMatrix(int[,] matr)
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
void FillMatrix(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to + 1);
        }
    }
}

int[,] CopyMatrix(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);
    int[,] new_matr = new int[row_size, column_size];

    for (int i = 0; i < row_size; i++) 
        for (int j = 0; j < column_size; j++) 
        new_matr[i, j] = matr[i, j];

    return new_matr;
}

FillMatrix(matrix, start, stop);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
int[,] matr_new = CopyMatrix(matrix);
PrintMatrix(matr_new);
Console.WriteLine();

