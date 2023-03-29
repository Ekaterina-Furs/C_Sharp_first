//Напишите программу , которая на вход принимает позиции элемента в двумерном массиве и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

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


void NumValue(int[,] matr)
{
    Console.Write("Enter the coordinate of the row: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the coordinate of the column: ");
    int m = int.Parse(Console.ReadLine()!);
    
    if (n > matr.GetLength(0) || m > matr.GetLength(1))
	{
	    Console.WriteLine("The number does not exist");
	}
	else
	{
	    Console.WriteLine($"The value of number is {matr[n-1,m-1]}");
	}
    Console.WriteLine();
}


FillMatrix(matrix, start, stop);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
NumValue(matrix);


