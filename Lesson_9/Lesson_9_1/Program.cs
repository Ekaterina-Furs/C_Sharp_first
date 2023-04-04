// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number M: ");
int num2 = int.Parse(Console.ReadLine()!);

void NaturalArr(int M, int N)
{
    if(M > N) return;
    NaturalArr(M, N-1);
    Console.Write($"{N} ");
}
NaturalArr(num, num2);