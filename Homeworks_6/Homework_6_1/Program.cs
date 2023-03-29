//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Counter(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"The number {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if(a > 0) count++;
}
        return count;
}
Console.WriteLine("Enter the number:  ");
int n = int.Parse(Console.ReadLine()!);
int result = Counter(n);
Console.WriteLine($"The number > 0 is {result}");



