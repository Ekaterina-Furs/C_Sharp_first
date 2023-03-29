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


void NumValue(int[,] matr, int m, int n)
{
    Console.WriteLine("Введите координату ряда:");
    int r = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату столбца:");
    int c = int.Parse(Console.ReadLine()!);
    
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
         {
            if(r > m && c > n) 
            {
                Console.WriteLine("The number does not exist");
            }
        else
        {
            object Num = matr.GetValue(r, c);
            Console.WriteLine(Num);
        }
    }
}

FillMatrix(matrix, start, stop);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
NumValue(matrix, row, column);


