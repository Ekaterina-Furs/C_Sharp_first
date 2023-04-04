//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

Console.Write("Enter number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine()!);

void EvenArray(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0) Console.Write($"{M} ");
    EvenArray(M + 1, N);
}
EvenArray(m, n);

