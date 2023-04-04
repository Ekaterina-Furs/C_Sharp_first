// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи 

Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);

void NaturalArr(int N)
{
    if(N == 0) return;
    NaturalArr(N-1);
    Console.Write($"{N} ");
}
NaturalArr(num);