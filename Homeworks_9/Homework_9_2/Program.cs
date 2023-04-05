//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Write("Enter number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine()!);

int SumNaturals(int M, int N)
{
    if(M == N) return N;
    return N + SumNaturals(M, N-1);
}
Console.Write($"The sum of numbers between {m} and {n} is {SumNaturals(m, n)}");