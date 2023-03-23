Console.WriteLine("Задайте размер массива -> ");
int num = int.Parse(Console.ReadLine()!);

int[] order = FillArray(num);
PrintArray(order);

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

int count = 0;
for (int i = 0; i < order.Length; i++)
{
    if (order[i] % 2 == 0)
        count++;
}

Console.WriteLine($"Четных чисел в массиве {count}");
