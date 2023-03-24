//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.

Console.Write("Set the size of the array -> ");
int num = int.Parse(Console.ReadLine()!);

Console.Write("The range of random numbers: FROM -> ");
int begin = int.Parse(Console.ReadLine()!);

Console.Write("The range of random numbers: TO -> ");
int end = int.Parse(Console.ReadLine()!);

double[] FillArray(int size, int begin, int end)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.NextDouble() * (end - begin) + begin;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"The difference between max and min is {max - min}.");
}
Console.WriteLine();
double[] order = FillArray(num, begin, end);
PrintArray(order);
Console.WriteLine();
Difference(order);
Console.WriteLine();
