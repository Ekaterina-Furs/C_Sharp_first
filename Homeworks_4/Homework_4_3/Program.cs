// Напишите программу , которая задает массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции.

Console.WriteLine("Задайте размер массива -> ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Диапазон случайных чисел С -> ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Диапазон случайных чисел ДО -> ");
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
        Console.Write($"{arr[i]} " );
    } 
    Console.WriteLine();   
}

int[] order = FillArray(num, start, stop);
PrintArray(order);

