﻿// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//    


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


int Sum(int[,] matr)
{
    int line = matr.GetLength(0);
    int pillar = matr.GetLength(1);
    int sum = 0;
    for (int i = 0; i < line; i++)
    {
       for (int j = 0;  j < pillar; j++)
       {
        if(i == j) sum += matr[i, j];
       } 
    }
    return sum;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers WITH -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers UP TO -> ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[row, column];


FillMatrix(matrix, start, stop);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(Sum(matrix));