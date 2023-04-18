//Задайте прямоугольный двумерный  массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.

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
// одномерный массив, сумма элементов в строке
int[] Sum(int[,] matr)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    int[] allnums = new int[row];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            allnums[i] += matr[i, j];
        }
    }
    return allnums;
}

//находим одномерный массив(строку) с мин суммой элементов

void FindMin(int[] arr)
{
    int minindex = 0;
    for (int i = 1; i < arr.Length; i++) 
    {
        if (arr[i] < arr[minindex]) minindex = i;
    }
    Console.WriteLine($"Sum of the elements: {arr[minindex]}, line: {minindex + 1}");
    
}
Console.WriteLine("The random matrix is:");
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
Console.WriteLine();
FindMin(Sum(matrix));
Console.WriteLine();