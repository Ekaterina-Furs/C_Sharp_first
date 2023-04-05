//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers WITH -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers UP TO -> ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();
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

void OrderMinElement(int[,] matr)
{
    int rowsize = matr.GetLength(0);
    int columnsize = matr.GetLength(1);

    for (int i = 0; i < rowsize; i++)
    {
        for (int j = 0; j < columnsize; j++)
        {
            for (int k = 0; k < columnsize - j - 1; k++)
                if (matr[i, k] < matr[i, k + 1])
            (matr[i, k],  matr[i, k + 1]) = (matr[i, k + 1], matr[i, k]);
        }
    }
}
Console.WriteLine("The random matrix is:");
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
Console.WriteLine();
OrderMinElement(matrix);
Console.WriteLine("The new matrix is:");
PrintMatrix(matrix);
