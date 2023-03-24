//Задайте массив, заполненный случайными положительными трехзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.

Console.Write("Set the size of the array -> ");
int num = int.Parse(Console.ReadLine()!);

int[] order = FillArray(num);
PrintArray(order);
CounterEven(order);

int[] FillArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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

int CounterEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }
    return res; 
}

Console.WriteLine($"The number of even numbers is {CounterEven(order)}");

