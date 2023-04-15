//3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplicacion(int[,] firstArray, int[,] secondArray)
{
    int row1 = firstArray.GetLength(0);
    int column1 =  firstArray.GetLength(1);

    int row2 = secondArray.GetLength(0);
    int column2 =  secondArray.GetLength(1);

    int[,] resultmatrix = new int[row1, column2];

    if(column1 != row2) return resultmatrix;
    else if(column1 == row2)
    {
        resultmatrix = new int[row1, column2];
    }
        

    for(int i=0; i < row1; i++)
    {
        for(int j =0; j <column2; j++)
        {
            for(int p=0; p < column1; p++)
//берем строку первой матрицы и столбец второй
//перемножаем элменты, собираем сумму произведений.

            resultmatrix[i,j] += firstArray[i,p] * secondArray[p, j];
        }
    }
return resultmatrix;
}

Console.WriteLine("The random matrix is:");
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("The random matrix is:");
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
Console.WriteLine();

MatrixMultiplicacion(matrix, matrix);
Console.WriteLine();