//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("введите количество элементов:");
int m = int.Parse(Console.ReadLine()!);
int[] array = new int[m];

int[] FillArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
        Console.Write($"{arr[i]}  ");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} " );
    } 
    Console.WriteLine();   
}

int[] order = FillArray(m);
PrintArray(order);


