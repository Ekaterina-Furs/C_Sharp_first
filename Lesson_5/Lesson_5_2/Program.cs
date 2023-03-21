// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.
int[] Mas(int long_1, int min, int max)
{
    int[] array = new int[long_1];
    for (int i = 0; i < long_1; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void Print(int[] array)
{
    Console.WriteLine("Ваш массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
bool TryFols(int[] array, int desirednumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == desirednumber)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите длину массива:");
int long_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение массива:");
int min_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение массива :");
int max_1 = int.Parse(Console.ReadLine()!);
int[] array_1 = Mas(long_2, min_1, max_1);
Print(array_1);
int g = int.Parse(Console.ReadLine()!);
Console.WriteLine(TryFols(array_1, g));