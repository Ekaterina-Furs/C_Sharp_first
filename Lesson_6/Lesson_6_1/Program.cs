// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

void Triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

Triangle(a, b, c);