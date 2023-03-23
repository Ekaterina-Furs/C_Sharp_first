// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов , стоящих на нечетных позициях.

Console.Write("Set the size of the array -> ");
int num = int.Parse(Console.ReadLine()!);

Console.Write("The range of random numbers: FROM -> ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("The range of random numbers: TO -> ");
int stop = int.Parse(Console.ReadLine()!);


int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int PositionOdd(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] order = FillArray(num, start, stop);
PrintArray(order);
PositionOdd(order);
Console.WriteLine($"The sum of odd elements is {PositionOdd(order)}.");