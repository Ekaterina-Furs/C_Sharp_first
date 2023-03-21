// Напишите программу , которая задает массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции.

Console.Write("Задайте размер массива -> ");
int num = int.Parse(Console.ReadLine()!);


int[] array = new int [num];

void FillArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
   
}

void PrintArray(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(arr[i]);
    }
    
}
FillArray(array);
PrintArray(array);