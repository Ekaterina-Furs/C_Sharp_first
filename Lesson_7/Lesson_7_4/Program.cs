// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
//    выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.



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

string Find(int[,] matr, int a)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (a == matr[i, j]) return $"{i + 1},{j + 1}";

        }

    }
    return "No";
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers WITH -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers UP TO -> ");
int stop = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);


int[,] matrix = new int[row, column];


FillMatrix(matrix, start, stop);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(Find(matrix, num));